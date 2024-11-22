using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.Helpers
{
    public class DoctorService
    {
        private readonly string doctorFile;

        public DoctorService()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivos");
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            doctorFile = Path.Combine(folderPath, "doctores.txt");
        }

        public void GuardarDoctor(Doctor doctor)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(doctorFile, true))
                {
                    sw.WriteLine($"{doctor.Id}|{doctor.Nombre}|{doctor.Especialidad}|{doctor.Correo}|{doctor.Celular}|{doctor.Activo}");
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al guardar el doctor: {ex.Message}");
            }
        }

        public List<Doctor> LeerDoctores()
        {
            var doctores = new List<Doctor>();
            if (!File.Exists(doctorFile)) return doctores;

            try
            {
                foreach (var linea in File.ReadAllLines(doctorFile))
                {
                    var datos = linea.Split('|');
                    int id = int.Parse(datos[0]);
                    bool activo = bool.Parse(datos[5]);
                    doctores.Add(new Doctor(id, datos[1], datos[2], datos[3], datos[4], activo));
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al leer los doctores: {ex.Message}");
            }

            return doctores;
        }

        public void DarDeBajaDoctor(int id)
        {
            var doctores = LeerDoctores();
            bool doctorEncontrado = false;

            for (int i = 0; i < doctores.Count; i++)
            {
                if (doctores[i].Id == id)
                {
                    doctores[i].Activo = false;
                    doctorEncontrado = true;
                    break;
                }
            }

            if (!doctorEncontrado)
                throw new Exception("Doctor no encontrado.");

            try
            {
                using (StreamWriter sw = new StreamWriter(doctorFile))
                {
                    foreach (var doctor in doctores)
                    {
                        sw.WriteLine($"{doctor.Id}|{doctor.Nombre}|{doctor.Especialidad}|{doctor.Correo}|{doctor.Celular}|{doctor.Activo}");
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al actualizar los doctores: {ex.Message}");
            }
        }

        public void ActualizarDoctores(int idDoctor, string nombre, string especialidad, string correo, string celular)
        {
            var doctores = LeerDoctores();
            bool doctorEncontrado = false;

            for (int i = 0; i < doctores.Count; i++)
            {
                if (doctores[i].Id == idDoctor)
                {
                    doctores[i] = new Doctor
                    {
                        Id = idDoctor,
                        Nombre = nombre,
                        Especialidad = especialidad,
                        Correo = correo,
                        Celular = celular,
                        Activo = doctores[i].Activo
                    };
                    doctorEncontrado = true;
                    break;
                }
            }

            if (!doctorEncontrado)
                throw new Exception("Doctor no encontrado.");

            // Sobrescribe el archivo con la lista actualizada
            try
            {
                using (StreamWriter sw = new StreamWriter(doctorFile))
                {
                    foreach (var doctor in doctores)
                    {
                        sw.WriteLine($"{doctor.Id}|{doctor.Nombre}|{doctor.Especialidad}|{doctor.Correo}|{doctor.Celular}|{doctor.Activo}");
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al actualizar los doctores: {ex.Message}");
            }
        }

    }
}
