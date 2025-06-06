using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);
    public static bool HasPassed(DateTime appointmentDate)=>DateTime.Now > appointmentDate;
    public static bool IsAfternoonAppointment(DateTime appointmentDate)=> appointmentDate.Hour >= 12 && 18 > appointmentDate.Hour;
    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";
    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15,0,0,0);
   
}
