﻿using System.ComponentModel.DataAnnotations;

namespace APIProductos.Models
{
    public class ProductoEnCarrito
    {
        [Key]
        public int IdProductoEnCarrito { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        public int IdProducto { get; set; } 

        public int Cantidad { get; set; }
    }

}
