using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.Helpers
{
    internal class ControlTrabajos
    {
        // Carpeta donde se guardan los archivos de los trabajos
        private readonly string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Trabajos Investigativos");

        // Lista de trabajos (en un escenario real, esto podría estar conectado a una base de datos)
        private List<StrTrabajos> trabajos;

        public ControlTrabajos()
        {
            // Si la carpeta no existe, la crea
            if (!Directory.Exists(carpetaDestino))
            {
                Directory.CreateDirectory(carpetaDestino);
            }

            trabajos = new List<StrTrabajos>();
        }

        //Método para guardar un nuevo registro/trabajo
        public bool GuardarTrabajo(int idUsuario, string titulo, string descripcion, string categoria, string archivoPdf)
        {
            try
            {
                int idTrabajo = trabajos.Count + 1;

                // Generar el nombre del archivo con el IdTrabajo
                string archivoDestino = Path.Combine(carpetaDestino, $"{idTrabajo}.pdf");

                //Copiar el archivo PDF a la carpeta de destino
                File.Copy(archivoPdf, archivoDestino);

                //Crear un nuevo objeto StrTrabajos
                StrTrabajos nuevoTrabajo = new StrTrabajos
                    (
                    idTrabajo,
                    idUsuario,
                    titulo,
                    descripcion,
                    categoria,
                    DateTime.Now,
                    new Comentario(),  // Comentarios vacíos al principio
                    new Valoracion(),  // Calificación vacía al principio
                    archivoDestino  // Ruta del archivo PDF guardado
                    );
                trabajos.Add(nuevoTrabajo);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el trabajo: {ex.Message}");
                return false;
            }
        }

        //Método para leer 
        public List<StrTrabajos> ObtenerTrabajos()
        {
            return trabajos;
        }

        //Método para buscar un trabajo por id
        public StrTrabajos BuscarTrabajo(int idTrabajo)
        {
            return trabajos.FirstOrDefault(t => t.IdTrabajo == idTrabajo);
        }

        public bool ActualizarTrabajo(int idTrabajo, string titulo, string descripcion, string categoria)
        {
            try
            {
                var trabajo = trabajos.FirstOrDefault(t => t.IdTrabajo == idTrabajo);
                if (trabajo.Equals(default(StrTrabajos)))
                {
                    return false;
                }
                //Actualizamos los campos del trabajo encontrado
                trabajo.Titulo = titulo;
                trabajo.Descripcion = descripcion;
                trabajo.Categoria = categoria;

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el trabajo: {ex.Message}");
                return false;
            }
        }

        public bool EliminarTrabajo(int idTrabajo)
        {
            try
            {
                var trabajo = trabajos.FirstOrDefault(t => t.IdTrabajo==idTrabajo);
                if (trabajo.Equals(default(StrTrabajos)))
                {
                    return false;
                }

                trabajos.Remove(trabajo);
                return true;

            }catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el trabajo: {ex.Message}");
                return false;
            }
        }

        // Método para obtener la ruta de un archivo
        public string ObtenerRutaArchivo(int idTrabajo)
        {
            //Buscamos el trabajo por su ID
            var trabajo = trabajos.FirstOrDefault(t => t.IdTrabajo == idTrabajo);

            //Verificamos si el trabajo se encontró y devolvemos la RutaArchivo si existe
            if (trabajo.Equals(default(StrTrabajos)))
            {
                return null; //El trabajo no se encontró
            }

            return trabajo.RutaArchivo; //Devolvemos la ruta del archivo
        }

    }
}
