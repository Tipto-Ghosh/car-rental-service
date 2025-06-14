using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter.Services {
    public class AppointmentService {
        private AppointmentRepository appointmentRepo;

        public AppointmentService() {
            this.appointmentRepo = new AppointmentRepository();
        }

        public Appointment GetAppointmentById(int appointmentId) {
            return appointmentRepo.GetAppointmentById(appointmentId);
        }

        public List<Appointment> GetAppointmentsByCustomer(int customerId) {
            return appointmentRepo.GetAppointmentsByCustomerId(customerId);
        }

        public List<Appointment> GetAppointmentsByMechanic(int mechanicId) {
            return appointmentRepo.GetAppointmentsByMechanicId(mechanicId);
        }

        public List<Appointment> GetAllAppointments() {
            return appointmentRepo.GetAllAppointments();
        }
    }
}