using Health_Care_System.Data;
using Health_Care_System.Entities;

namespace Health_Care_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            var patients = new List<Patient>
                {
                    new Patient
                    {
                        Name = "Ahmed Ali",
                        BirthDate = new DateTime(1998, 5, 10)
                    },
                
                    new Patient
                    {
                        Name = "Sara Mohamed",
                        BirthDate = new DateTime(2001, 8, 20)
                    },
                
                    new Patient
                    {
                        Name = "Omar Hassan",
                        BirthDate = new DateTime(1995, 3, 15)
                    }
                };



            var doctors = new List<Doctor>
            {
                new Doctor
                {
                    Name = "Mona Ahmed",
                    Specialization = "Cardiology"
                },
            
                new Doctor
                {
                    Name = "Khaled Ali",
                    Specialization = "Dentistry"
                },
            
                new Doctor
                {
                    Name = "Sara Hassan",
                    Specialization = "Dermatology"
                }
            };


            var appointments = new List<Appointment>
            {
                new Appointment
                {
                    PatientId = 1,
                    DoctorId = 1,
                    AppointmentDate = new DateTime(2026, 10, 5)
                },
            
                new Appointment
                {
                    PatientId = 1,
                    DoctorId = 2,
                    AppointmentDate = new DateTime(2026, 10, 7)
                },
            
                new Appointment
                {
                    PatientId = 2,
                    DoctorId = 1,
                    AppointmentDate = new DateTime(2026, 10, 8)
                },
            
                new Appointment
                {
                    PatientId = 3,
                    DoctorId = 3,
                    AppointmentDate = new DateTime(2026, 10, 10)
                }
            };



            context.Set<Patient>().AddRange(patients);
            context.Set<Doctor>().AddRange(doctors);

            context.SaveChanges();

            context.Set<Appointment>().AddRange(appointments);

            context.SaveChanges();
        }
    }
}
