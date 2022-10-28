using Data.Seeding;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Data.Models
{
    public partial class ednita_dbContext : DbContext
    {
        public ednita_dbContext()
        {
        }

        public ednita_dbContext(DbContextOptions<ednita_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Archivo> Archivos { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Famiiliar> Famiiliars { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Oficina> Oficinas { get; set; }
        public virtual DbSet<Particulare> Particulares { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Peticionario> Peticionarios { get; set; }
        public virtual DbSet<Reporte> Reportes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedersIniciales.Seed(modelBuilder);

            modelBuilder.Entity<Archivo>(entity =>
            {
                entity.HasKey(e => e.Idarchivo)
                    .HasName("PRIMARY");

                entity.ToTable("archivo");

                entity.HasIndex(e => e.ParticularesIdParticulares, "fk_archivo_particulares1_idx");

                entity.HasIndex(e => e.IdPeticionario, "fk_archivo_peticionario1_idx");

                entity.Property(e => e.Idarchivo)
                    .HasMaxLength(90)
                    .HasColumnName("idarchivo");

                entity.Property(e => e.Amparo).HasMaxLength(45);

                entity.Property(e => e.Carpeta)
                    .HasMaxLength(45)
                    .HasColumnName("carpeta");

                entity.Property(e => e.Delito)
                    .HasMaxLength(255)
                    .HasColumnName("delito");

                entity.Property(e => e.Estatus).HasDefaultValue(EstatusArchivo.Activo);

                entity.Property(e => e.ExpedinteAmparo).HasMaxLength(45);

                entity.Property(e => e.Fiscalia).HasMaxLength(255);

                entity.Property(e => e.IdPeticionario)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("idPeticionario");

                entity.Property(e => e.Juez).HasMaxLength(45);

                entity.Property(e => e.ParticularesIdParticulares)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("particulares_idParticulares");

                entity.Property(e => e.ProcesoPenal)
                    .HasMaxLength(255)
                    .HasColumnName("procesoPenal");

                entity.Property(e => e.SegundaInstancia).HasMaxLength(45);

                entity.Property(e => e.Serieindevep).HasColumnName("serieindevep");

                entity.Property(e => e.Toca).HasMaxLength(45);

                entity.Property(e => e.Victima).HasMaxLength(255);

                entity.HasOne(d => d.IdPeticionarioNavigation)
                    .WithMany(p => p.Archivos)
                    .HasForeignKey(d => d.IdPeticionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_archivo_peticionario1");

                entity.HasOne(d => d.ParticularesIdParticularesNavigation)
                    .WithMany(p => p.Archivos)
                    .HasForeignKey(d => d.ParticularesIdParticulares)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_archivo_particulares1");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.Idcargo)
                    .HasName("PRIMARY");

                entity.ToTable("cargo");

                entity.Property(e => e.Idcargo)
                    .HasMaxLength(90)
                    .HasColumnName("idcargo");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(90)
                    .HasColumnName("puesto");
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.Idcitas)
                    .HasName("PRIMARY");

                entity.ToTable("citas");

                entity.HasIndex(e => e.ArchivoIdarchivo, "fk_citas_archivo1_idx1");

                entity.HasIndex(e => e.ReportesIdreportes, "fk_citas_reportes1_idx");

                entity.Property(e => e.Idcitas)
                    .HasMaxLength(90)
                    .HasColumnName("idcitas");

                entity.Property(e => e.ArchivoIdarchivo)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("archivo_idarchivo");

                entity.Property(e => e.Audiencia)
                    .HasMaxLength(155)
                    .HasColumnName("audiencia");

                entity.Property(e => e.ReportesIdreportes)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("reportes_idreportes");

                entity.Property(e => e.ResultadoAudiencia).HasColumnType("longtext");

                entity.Property(e => e.Sala)
                    .HasMaxLength(45)
                    .HasColumnName("sala");

                entity.HasOne(d => d.ArchivoIdarchivoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.ArchivoIdarchivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_citas_archivo1");

                entity.HasOne(d => d.ReportesIdreportesNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.ReportesIdreportes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_citas_reportes1");
            });

            modelBuilder.Entity<Famiiliar>(entity =>
            {
                entity.HasKey(e => new { e.PersonaIdPersona, e.PeticionarioIdPeticionario })
                    .HasName("PRIMARY");

                entity.ToTable("famiiliar");

                entity.HasIndex(e => e.PersonaIdPersona, "fk_famiiliar_persona1_idx");

                entity.HasIndex(e => e.PeticionarioIdPeticionario, "fk_famiiliar_peticionario1_idx");

                entity.Property(e => e.PersonaIdPersona)
                    .HasMaxLength(90)
                    .HasColumnName("persona_idPersona");

                entity.Property(e => e.PeticionarioIdPeticionario)
                    .HasMaxLength(90)
                    .HasColumnName("peticionario_idPeticionario");

                entity.HasOne(d => d.PersonaIdPersonaNavigation)
                    .WithMany(p => p.Famiiliars)
                    .HasForeignKey(d => d.PersonaIdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_famiiliar_persona");

                entity.HasOne(d => d.PeticionarioIdPeticionarioNavigation)
                    .WithMany(p => p.Famiiliars)
                    .HasForeignKey(d => d.PeticionarioIdPeticionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_famiiliar_peticionario");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PRIMARY");

                entity.ToTable("funcionario");

                entity.HasIndex(e => e.CargoIdcargo, "fk_Funcionario_cargo1_idx");

                entity.HasIndex(e => e.OficinaIdoficina, "fk_Funcionario_oficina1_idx");

                entity.HasIndex(e => e.PersonaIdPersona, "fk_Funcionario_persona1_idx");

                entity.Property(e => e.IdFuncionario)
                    .HasMaxLength(90)
                    .HasColumnName("idFuncionario");

                entity.Property(e => e.CargoIdcargo)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("cargo_idcargo");

                entity.Property(e => e.OficinaIdoficina)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("oficina_idoficina");

                entity.Property(e => e.PersonaIdPersona)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("persona_idPersona");

                entity.HasOne(d => d.CargoIdcargoNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.CargoIdcargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Funcionario_cargo1");

                entity.HasOne(d => d.OficinaIdoficinaNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.OficinaIdoficina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Funcionario_oficina1");

                entity.HasOne(d => d.PersonaIdPersonaNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.PersonaIdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Funcionario_persona1");
            });

            modelBuilder.Entity<Oficina>(entity =>
            {
                entity.HasKey(e => e.Idoficina)
                    .HasName("PRIMARY");

                entity.ToTable("oficina");

                entity.Property(e => e.Idoficina)
                    .HasMaxLength(90)
                    .HasColumnName("idoficina");

                entity.Property(e => e.Abreviatura)
                    .HasMaxLength(45)
                    .HasColumnName("abreviatura");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Particulare>(entity =>
            {
                entity.HasKey(e => e.IdParticulares)
                    .HasName("PRIMARY");

                entity.ToTable("particulares");

                entity.HasIndex(e => e.IdPeticionario, "fk_particulares_peticionario1_idx");

                entity.Property(e => e.IdParticulares)
                    .HasMaxLength(90)
                    .HasColumnName("idParticulares");

                entity.Property(e => e.EstadoCivil).HasMaxLength(45);

                entity.Property(e => e.Estudios).HasMaxLength(45);

                entity.Property(e => e.IdPeticionario)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("idPeticionario");

                entity.Property(e => e.Ocupacion)
                    .HasMaxLength(45)
                    .HasColumnName("ocupacion");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PRIMARY");

                entity.ToTable("persona");

                entity.Property(e => e.IdPersona)
                    .HasMaxLength(90)
                    .HasColumnName("idPersona");

                entity.Property(e => e.Amaterno)
                    .HasMaxLength(150)
                    .HasColumnName("amaterno");

                entity.Property(e => e.Apaterno)
                    .HasMaxLength(150)
                    .HasColumnName("apaterno");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Peticionario>(entity =>
            {
                entity.HasKey(e => e.IdPeticionario)
                    .HasName("PRIMARY");

                entity.ToTable("peticionario");

                entity.HasIndex(e => e.FuncionarioIdFuncionario, "fk_peticionario_funcionario1_idx");

                entity.HasIndex(e => e.PersonaIdPersona, "fk_peticionario_persona1_idx");

                entity.Property(e => e.IdPeticionario)
                    .HasMaxLength(90)
                    .HasColumnName("idPeticionario");

                entity.Property(e => e.Alias)
                    .HasMaxLength(150)
                    .HasColumnName("alias");

                entity.Property(e => e.Domicilio).HasMaxLength(255);

                entity.Property(e => e.FuncionarioIdFuncionario)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("funcionario_idFuncionario");

                entity.Property(e => e.GrupoEtnico).HasMaxLength(150);

                entity.Property(e => e.IdentidadResguardada)
                    .HasMaxLength(90)
                    .HasColumnName("identidadResguardada");

                entity.Property(e => e.Lengua).HasMaxLength(150);

                entity.Property(e => e.PersonaIdPersona)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("persona_idPersona");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(45)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.FuncionarioIdFuncionarioNavigation)
                    .WithMany(p => p.Peticionarios)
                    .HasForeignKey(d => d.FuncionarioIdFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_peticionario_funcionario1");

                entity.HasOne(d => d.PersonaIdPersonaNavigation)
                    .WithMany(p => p.Peticionarios)
                    .HasForeignKey(d => d.PersonaIdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_peticionario_persona1");
            });

            modelBuilder.Entity<Reporte>(entity =>
            {
                entity.HasKey(e => e.Idreportes)
                    .HasName("PRIMARY");

                entity.ToTable("reportes");

                entity.Property(e => e.Idreportes)
                    .HasMaxLength(90)
                    .HasColumnName("idreportes");

                entity.Property(e => e.Fecha).HasColumnName("fecha");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
