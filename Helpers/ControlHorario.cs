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
                    sw.WriteLine($"{horario.ID}|{horario.DoctorID}|{horario.HoraInicial}|{horario.HoraFinal}|{horario.DiaSemana}|{horario.Activo = true}");
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al guardar el doctor: {ex.Message}");
            }
        }

        public List<Horario> LeerHorarios()
        {
            var horario = new List<Horario>();
            if (!File.Exists(horarioFile)) return horario;

            try
            {
                foreach (var linea in File.ReadAllLines(horarioFile))
                {
                    var datos = linea.Split('|');
                    int idHorario = int.Parse(datos[0]);
                    int idDoctor = int.Parse(datos[1]);
                    DateTime fechaInicio = DateTime.Parse(datos[2]);
                    DateTime fechaFinal = DateTime.Parse(datos[3]);
                    bool activo = bool.Parse(datos[5]);
                    horario.Add(new Horario(idHorario, idDoctor, fechaInicio, fechaFinal, datos[4], activo));
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al leer los doctores: {ex.Message}");
            }

            return horario;
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
