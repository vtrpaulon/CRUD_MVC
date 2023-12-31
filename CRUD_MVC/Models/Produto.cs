﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name ="Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name ="Nome")]
        public string Nome { get; set; }
    }
}
