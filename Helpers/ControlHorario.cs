using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.Helpers
{
    
    internal class ControlHorario
    {
        private readonly string horarioFile;
        private readonly string folderPath;


        public ControlHorario()
        {
            folderPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Archivos");
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            horarioFile = Path.Combine(folderPath, "horario.txt");
        }

        public void GuardarHorarios(Horario horario)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(horarioFile, true))
                {
                    sw.WriteLine($"{horario.ID}|{horario.DoctorID}|{horario.HoraInicial}|{horario.HoraFinal}|{horario.DiaSemana}|{horario.Activo}");
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al guardar el doctor: {ex.Message}");
            }
        }

        public List<Horario> LeerHorarios()
        {
            var horarios = new List<Horario>();
            try
            {
                if (File.Exists(horarioFile))
                {
                    foreach (var linea in File.ReadAllLines(horarioFile))
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;

                        var datos = linea.Split('|');
                        if (datos.Length != 6) continue; // Asegurar que hay 6 columnas

                        if (int.TryParse(datos[0], out int idHorario) &&
                            int.TryParse(datos[1], out int idDoctor) &&
                            DateTime.TryParse(datos[2], out DateTime horaInicial) &&
                            DateTime.TryParse(datos[3], out DateTime horaFinal) &&
                            bool.TryParse(datos[5], out bool activo))
                        {
                            horarios.Add(new Horario(idHorario, idDoctor, horaInicial, horaFinal, datos[4], activo));
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al leer los horarios: {ex.Message}");
            }

            return horarios;
        }

        public void DarDeBajaDoctor(int id)
        {
            var horarios = LeerHorarios();

            for (int i = 0; i < horarios.Count; i++)
            {
                if (horarios[i].ID == id)
                {
                    horarios[i] = new Horario
                    {
                        ID = horarios[i].ID,
                        DoctorID = horarios[i].DoctorID,
                        HoraInicial = horarios[i].HoraInicial,
                        HoraFinal = horarios[i].HoraFinal,
                        DiaSemana = horarios[i].DiaSemana,
                        Activo = false
                    };
                    break;

                }
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(horarioFile))
                {
                    foreach (var horario in horarios)
                    {
                        sw.WriteLine($"{horario.ID}|{horario.DoctorID}|{horario.HoraInicial}|{horario.HoraFinal}|{horario.DiaSemana}|{horario.Activo}|");
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al actualizar los horarios: {ex.Message}");
            }
        }

        public void ActualizarHorarios(int id, int idDoctor, DateTime horaInicial, DateTime horaFinal, string diaSemana, bool activo)
        {
            var horarios = LeerHorarios();

            for (int i = 0; i < horarios.Count; i++)
            {
                if (horarios[i].ID == id)
                {
                    horarios[i] = new Horario
                    {
                        ID = id,
                        DoctorID = idDoctor,
                        HoraInicial = horaInicial,
                        HoraFinal = horaInicial,
                        DiaSemana = diaSemana,
                        Activo = horarios[i].Activo
                    };
                    break;
                }
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(horarioFile))
                {
                    foreach (var horario in horarios)
                    {
                        sw.WriteLine($"{horario.ID}|{horario.DoctorID}|{horario.HoraInicial}|{horario.HoraFinal}|{horario.DiaSemana}|{horario.Activo}|");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

    }
}
