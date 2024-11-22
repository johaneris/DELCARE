using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM_INVESTIGATION.Estructuras
{

    public struct Valoracion
    {
        public int IdCalificacion { get; set; }
        public int IdTrabajo { get; set; }
        public int Calificacion {  get; set; }

        public Valoracion(int idCalificacion, int idTrabajo, int calificacion)
        {
            IdCalificacion = idCalificacion;
            IdTrabajo = idTrabajo;
            Calificacion = calificacion;
        }
    }
    public struct Comentario
    {
        public int IdComentario { get; set; }
        public int IdUsuario { get; set; }
        public int IdTrabajo { get; set; }
        public string TextoComentario { get; set; }
        public DateTime FechaSubidaComentario { get; set; }

        public Comentario(int idComentario, int idUsuario, int idTrabajo, string textoComentario, DateTime fechaSubidaComentario)
        {
            IdComentario = idComentario;
            IdUsuario = idUsuario;
            IdTrabajo = idTrabajo;
            TextoComentario = textoComentario;
            FechaSubidaComentario = fechaSubidaComentario;
        }
    }

    public struct StrTrabajos
    {
        public int IdTrabajo { get; set; }
        public int IdUsuario { get; set; }
        public string Titulo
        { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaSubida { get; set; }
        public Comentario Comentarios { get; set; } 
        public Valoracion Calificacion { get; set; }
        public string RutaArchivo { get; set; }

        public StrTrabajos(int idTrabajo, int idUsuario, string nombreTitulo, string descripcion, string categoria, DateTime fechaSubida, Comentario comentarios, Valoracion calificacion, string rutaArchivo)
        {
            IdTrabajo = idTrabajo;
            IdUsuario = idUsuario;
            Titulo = nombreTitulo;
            Descripcion = descripcion;
            Categoria = categoria;
            FechaSubida = fechaSubida;
            Comentarios = comentarios;
            Calificacion = calificacion;
            RutaArchivo = rutaArchivo;
        }
    }

}
