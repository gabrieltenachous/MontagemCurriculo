﻿using Microsoft.EntityFrameworkCore;
using MontagemCr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Curriculo> Curriculos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<TipoCurso> TiposCursos { get; set; }
        public DbSet<FormacaoAcademica> FormacoesAcademicas { get; set; }
        public DbSet<ExperienciaProfissional> ExperienciasProfissionais { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<InformacaoLogin> InformacoesLogin { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }
    }
}
