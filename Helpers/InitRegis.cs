using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.Helpers
{
    internal class InitRegis
    {
        // Ruta de la carpeta "Archivos" dentro de la carpeta principal del proyecto
        private readonly string folderPath;
        private readonly string usuarioEstFile;
        private readonly string usuarioAdminFile;

        // Constructor
        public InitRegis()
        {
            // Obtener la ruta de la carpeta principal del proyecto
            folderPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Archivos");

            // Crear la carpeta "Archivos" si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Inicializar las rutas de archivo
            usuarioEstFile = Path.Combine(folderPath, "usuariosEst.txt");
            usuarioAdminFile = Path.Combine(folderPath, "usuariosAdmin.txt");
        }

        // Registrar UsuarioEst
        public void RegistrarUsuarioEst(UsuarioEst nuevoUsuario)
        {
            UsuarioEst usuarioConId = new UsuarioEst(nuevoUsuario.Id, nuevoUsuario.Nombre, nuevoUsuario.Correo, nuevoUsuario.Contrasenia, nuevoUsuario.Estado);

            if (!File.Exists(usuarioEstFile))
            {
                File.Create(usuarioEstFile).Close();
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(usuarioEstFile, true))
                {
                    sw.WriteLine($"{usuarioConId.Id}|{usuarioConId.Nombre}|{usuarioConId.Correo}|{usuarioConId.Contrasenia}|{usuarioConId.Estado}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al acceder al archivo: {ex.Message}");
            }
        }

        // Registrar UsuarioAdmin
        public void RegistrarUsuarioAdmin(UsuarioAdmin nuevoAdmin)
        {
            UsuarioAdmin adminConId = new UsuarioAdmin(nuevoAdmin.Id, nuevoAdmin.Nombre, nuevoAdmin.Correo, nuevoAdmin.Contrasenia);

            if (!File.Exists(usuarioAdminFile))
            {
                File.Create(usuarioAdminFile).Close();
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(usuarioAdminFile, true))
                {
                    sw.WriteLine($"{adminConId.Id}|{adminConId.Nombre}|{adminConId.Correo}|{adminConId.Contrasenia}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al acceder al archivo: {ex.Message}");
            }
        }

        // Iniciar Sesión Estudiantes (Correo y Contraseña)
        public bool IniciarSesionEstCorreo(string correo, string contrasenia)
        {
            var usuarios = LeerUsuariosEst();
            if (!usuarios.Any())
            {
                Console.WriteLine("No hay usuarios registrados en el sistema.");
                return false;
            }
            foreach (var usuario in LeerUsuariosEst())
            {
                if (usuario.Correo == correo && usuario.Contrasenia == contrasenia)
                {
                    return true;
                }
                
            }
            Console.WriteLine("Las credenciales son incorrectas, por favor intente de nuevo...");
            return false;
        }

        // Iniciar Sesión Estudiantes (CIF y Contraseña)
        

        // Iniciar Sesión Administradores
        public bool IniciarSesionAdmin(string correo, string contrasenia)
        {
            foreach (var usuario in LeerUsuariosAdmin())
            {
                if (usuario.Correo == correo && usuario.Contrasenia == contrasenia)
                {
                    return true;
                }
                
            }
            Console.WriteLine("Las credenciales son incorrectas, por favor intente de nuevo...");
            return false;
        }

        // Leer Usuarios Estudiantes
        public List<UsuarioEst> LeerUsuariosEst()
        {
            var usuarios = new List<UsuarioEst>();
            try
            {
                if (File.Exists(usuarioEstFile))
                {
                    foreach (var linea in File.ReadLines(usuarioEstFile))
                    {
                        var datos = linea.Split('|');
                        int id = int.Parse(datos[0]);
                        bool estado = bool.Parse(datos[4]);
                        usuarios.Add(new UsuarioEst(id, datos[1], datos[2], datos[3], estado));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al acceder al archivo: {ex.Message}");
            }
            return usuarios;
        }

        // Leer Usuarios Administradores
        public List<UsuarioAdmin> LeerUsuariosAdmin()
        {
            var admins = new List<UsuarioAdmin>();
            try
            {
                if (File.Exists(usuarioAdminFile))
                {
                    foreach (var linea in File.ReadLines(usuarioAdminFile))
                    {
                        var datos = linea.Split('|');
                        int id = int.Parse(datos[0]);
                        admins.Add(new UsuarioAdmin(id, datos[1], datos[2], datos[3]));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al acceder al archivo: {ex.Message}");
            }
            return admins;
        }

        // Verificar si un correo existe en Estudiantes
        public bool CorreoExistenteEnEstudiantes(string correo)
        {
            foreach (var usuario in LeerUsuariosEst())
            {
                if (usuario.Correo == correo)
                {
                    return true;
                }
            }
            return false;
        }

        // Verificar si un correo existe en Administradores
        public bool CorreoExisteEnAdmins(string correo)
        {
            foreach (var admin in LeerUsuariosAdmin())
            {
                if (admin.Correo == correo)
                {
                    return true;
                }
            }
            return false;
        }

        // Actualizar Usuario Administrador
        public void ActualizarUsuarioAdmin(int id, string nuevoNombre, string nuevoCorreo, string nuevaContrasenia)
        {
            var admins = LeerUsuariosAdmin();
            for (int i = 0; i < admins.Count; i++)
            {
                if (admins[i].Id == id)
                {
                    admins[i] = new UsuarioAdmin(id, nuevoNombre, nuevoCorreo, nuevaContrasenia);
                    break;
                }
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(usuarioAdminFile))
                {
                    foreach (var admin in admins)
                    {
                        sw.WriteLine($"{admin.Id}|{admin.Nombre}|{admin.Correo}|{admin.Contrasenia}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al escribir en el archivo: {ex.Message}");
            }
        }

        public void ActualizarUsuarioEst(int id, string nuevoNombre, string nuevoCorreo, string nuevaContrasenia, bool estado)
        {
            var estudiantes = LeerUsuariosEst();
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Id == id)
                {
                    // Reemplazar el estudiante encontrado con los nuevos datos
                    estudiantes[i] = new UsuarioEst(id, nuevoNombre, nuevoCorreo,  nuevaContrasenia, estado);
                    break;
                }
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(usuarioEstFile)) // Archivo donde se almacenan los estudiantes
                {
                    foreach (var estudiante in estudiantes)
                    {
                        sw.WriteLine($"{estudiante.Id}|{estudiante.Nombre}|{estudiante.Correo}|{estudiante.Contrasenia}|{estudiante.Estado}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al escribir en el archivo: {ex.Message}");
            }
        }


        // Dar de baja a un usuario estudiante
        public void DarDeBajaUsuario(int id)
        {
            var estudiantes = LeerUsuariosEst();
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Id == id)
                {
                    estudiantes[i] = new UsuarioEst
                    {
                        Id = estudiantes[i].Id,
                        Nombre = estudiantes[i].Nombre,
                        Correo = estudiantes[i].Correo,
                       
                        Contrasenia = estudiantes[i].Contrasenia,
                       
                        Estado = false
                    };
                    break;
                }
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(usuarioEstFile))
                {
                    foreach (var est in estudiantes)
                    {
                        sw.WriteLine($"{est.Id}|{est.Nombre}|{est.Correo}|{est.Contrasenia}|{est.Estado}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al escribir en el archivo: {ex.Message}");
            }
        }
    }
}
