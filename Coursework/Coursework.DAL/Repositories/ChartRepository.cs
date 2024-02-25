using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows;
using Coursework.DAL.Interfaces;
using Coursework.Domain;

namespace Coursework.DAL.Repositories;

public class ChartRepository : IRepository<Chart>
{
    private readonly string _connectionString;

    public ChartRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Chart> GetCollection()
    {
        List<Chart> collection = new List<Chart>();
        string sqlExpression = "SELECT * FROM Chart";
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
 
            SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        int chamberId = reader.GetInt32(1);
                        int doctorId = reader.GetInt32(2);
                        int patientId = reader.GetInt32(3);
                        int illnessId = reader.GetInt32(4);
                        DateTime? start = null;
                        if (!reader.IsDBNull(5))
                            start = reader.GetDateTime(5);
                        DateTime? finish = null;
                        if (!reader.IsDBNull(6))
                            finish = reader.GetDateTime(6);
                        string content = reader.GetString(7);
                        collection.Add(new Chart
                            { Id = id, ChamberId = chamberId, DoctorId = doctorId, PatientId = patientId, 
                                IllnessId = illnessId, Start = start, Finish = finish, Content = content});
                    }
                }
            }
        }

        return collection;
    }

    public Chart? GetItem(int id)
    {
        return GetCollection().FirstOrDefault(item => item.Id == id);
    }

    public void Create(Chart item)
    {
        string sqlExpression = "INSERT INTO Chart (ChamberId, DoctorId, PatientId, IllnessId, Start, Finish, Content) VALUES (@ChamberId, @DoctorId, @PatientId, @IllnessId, @Start, @Finish, @Content)";
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
 
            SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
            SQLiteParameter chamberIdParameter = new SQLiteParameter("@ChamberId", item.ChamberId);
            SQLiteParameter doctorIdParameter = new SQLiteParameter("@DoctorId", item.DoctorId);
            SQLiteParameter patientIdParameter = new SQLiteParameter("@PatientId", item.PatientId);
            SQLiteParameter illnessIdParameter = new SQLiteParameter("@IllnessId", item.IllnessId);
            string? start = null;
            string? finish = null;
            if (item.Start != null)
            {
                start = ((DateTime)item.Start).ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (item.Finish != null)
            {
                finish = ((DateTime)item.Finish).ToString("yyyy-MM-dd HH:mm:ss");
            }
            SQLiteParameter startParameter = new SQLiteParameter("@Start", start);
            SQLiteParameter finishParameter = new SQLiteParameter("@Finish", finish);
            SQLiteParameter contentParameter = new SQLiteParameter("@Content", item.Content);
            command.Parameters.Add(chamberIdParameter);
            command.Parameters.Add(doctorIdParameter);
            command.Parameters.Add(patientIdParameter);
            command.Parameters.Add(illnessIdParameter);
            command.Parameters.Add(startParameter);
            command.Parameters.Add(finishParameter);
            command.Parameters.Add(contentParameter);
            command.ExecuteNonQuery();
        }
    }

    public void Update(Chart old, Chart @new)
    {
        string sqlExpression = "UPDATE Chart SET ChamberId=@ChamberId, DoctorId=@DoctorId, PatientId=@PatientId, IllnessId=@IllnessId, Start=@Start, Finish=@Finish, Content=@Content WHERE ChamberId=@OldChamberId and DoctorId=@OldDoctorId and PatientId=@OldPatientId and IllnessId=@OldIllnessId and Start=@OldStart and Content=@OldContent";

        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
            command.Parameters.AddWithValue("@ChamberId", @new.ChamberId);
            command.Parameters.AddWithValue("@DoctorId", @new.DoctorId);
            command.Parameters.AddWithValue("@PatientId", @new.PatientId);
            command.Parameters.AddWithValue("@IllnessId", @new.IllnessId);
            command.Parameters.AddWithValue("@Start", @new.Start);
            command.Parameters.AddWithValue("@Finish", @new.Finish);
            command.Parameters.AddWithValue("@Content", @new.Content);
            command.Parameters.AddWithValue("@OldChamberId", old.ChamberId);
            command.Parameters.AddWithValue("@OldDoctorId", old.DoctorId);
            command.Parameters.AddWithValue("@OldPatientId", old.PatientId);
            command.Parameters.AddWithValue("@OldIllnessId", old.IllnessId);
            command.Parameters.AddWithValue("@OldStart", old.Start);
            command.Parameters.AddWithValue("@OldContent", old.Content);

            int number = command.ExecuteNonQuery();
        }
    }   

    public void Delete(int id)
    {
        string sqlExpression = $"DELETE FROM Chart WHERE Id={id}";
 
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
 
            SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
            int number = command.ExecuteNonQuery();
        }
    }
}