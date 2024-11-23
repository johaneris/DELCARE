using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.Helpers
{
    internal class ControlCitas
    {
        private readonly string citasFile;
        private readonly string folderPath;

        public ControlCitas()
        {
            folderPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Archivos");
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            citasFile = Path.Combine(folderPath, "Citas.txt");
        }

        public void GuardarCitar (Citas citas)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(citasFile, true))
                {
                    sw.WriteLine($"{citas.Id}|{citas.NombrePaciente}|{citas.IdDoctor}|{citas.FechaHora}|{citas.NumPaciente}||{citas.Descripcion}{citas.Activo = true}");
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al agendar la cita: {ex.Message}");
            }
        }

        public List<Citas> LeerCitas()
        {
            var citas = new List<Citas>();
            if (!File.Exists(citasFile)) return citas;

            try
            {
                foreach (var linea in File.ReadAllLines(citasFile))
                {
                    var datos = linea.Split('|');
                    int idCitas = int.Parse(datos[0]);
                    int idDoctor = int.Parse(datos[2]);
                    bool activo = bool.Parse(datos[6]);
                    citas.Add(new Citas(idCitas, datos[1], idDoctor, datos[3], datos[4], datos[5], activo));
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error al leer las citas: {ex.Message}");
            }

            return citas;
        }

    }
}
