using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPurging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            string warningThreshold = "80"; // Set the warning threshold in percentage

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to check the database size and free space
                    string query = @"
                    SELECT
                        DB_NAME() AS DatabaseName,
                        SUM(size * 8.0 / 1024) AS TotalSizeMB,
                        SUM(FILEPROPERTY(name, 'SpaceUsed') * 8.0 / 1024) AS UsedSpaceMB,
                        (SUM(size * 8.0 / 1024) - SUM(FILEPROPERTY(name, 'SpaceUsed') * 8.0 / 1024)) AS FreeSpaceMB
                    FROM sys.master_files
                    WHERE type = 0
                    GROUP BY type;
                ";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        double totalSizeMB = Convert.ToDouble(reader["TotalSizeMB"]);
                        double usedSpaceMB = Convert.ToDouble(reader["UsedSpaceMB"]);
                        double freeSpaceMB = Convert.ToDouble(reader["FreeSpaceMB"]);
                        double usedPercentage = (usedSpaceMB / totalSizeMB) * 100;

                        Console.WriteLine($"Total Size: {totalSizeMB} MB");
                        Console.WriteLine($"Used Space: {usedSpaceMB} MB");
                        Console.WriteLine($"Free Space: {freeSpaceMB} MB");
                        Console.WriteLine($"Used Percentage: {usedPercentage}%");

                        // Check if the used percentage exceeds the threshold
                        if (usedPercentage >= Convert.ToDouble(warningThreshold))
                        {
                            Console.WriteLine("Warning: Your database memory is full.");
                        }
                        else
                        {
                            Console.WriteLine("Database memory usage is within limits.");
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
    }
    }
}
