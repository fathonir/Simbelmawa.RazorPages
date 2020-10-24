using Microsoft.EntityFrameworkCore;
using Simbelmawa.Models.Pengguna;

namespace Simbelmawa.Data
{
    public partial class PenggunaDbContext : DbContext
    {
        public PenggunaDbContext()
        {
        }

        public PenggunaDbContext(DbContextOptions<PenggunaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IdentitasPengguna> IdentitasPengguna { get; set; }
        public virtual DbSet<KelompokPeran> KelompokPeran { get; set; }
        public virtual DbSet<KontakPicPenggunaInstitusi> KontakPicPenggunaInstitusi { get; set; }
        public virtual DbSet<LoginGagal> LoginGagal { get; set; }
        public virtual DbSet<PengirimanUser> PengirimanUser { get; set; }
        public virtual DbSet<Peran> Peran { get; set; }
        public virtual DbSet<PeranOperator> PeranOperator { get; set; }
        public virtual DbSet<PeranPengguna> PeranPengguna { get; set; }
        public virtual DbSet<Sertifikat> Sertifikat { get; set; }
        public virtual DbSet<StatusPengguna> StatusPengguna { get; set; }
        public virtual DbSet<StatusPeranPengguna> StatusPeranPengguna { get; set; }
        public virtual DbSet<TataranPengguna> TataranPengguna { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("adminpack")
                .HasPostgresExtension("dblink")
                .HasPostgresExtension("uuid-ossp");

            modelBuilder.Entity<IdentitasPengguna>(entity =>
            {
                entity.HasKey(e => e.IdPersonal)
                    .HasName("identitas_pengguna_pkey");

                entity.ToTable("identitas_pengguna", "pengguna");

                entity.HasIndex(e => e.IdInstitusi)
                    .HasName("identitas_pengguna_id_institusi_idx");

                entity.HasIndex(e => e.IdPersonal)
                    .HasName("identitas_pengguna_id_personal_idx");

                entity.HasIndex(e => new { e.NamaUser, e.Pswd })
                    .HasName("identitas_pengguna_nama_user_pswd_idx");

                entity.Property(e => e.IdPersonal)
                    .HasColumnName("id_personal")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdInstitusi).HasColumnName("id_institusi");

                entity.Property(e => e.KdStsPengguna).HasColumnName("kd_sts_pengguna");

                entity.Property(e => e.NamaUser)
                    .IsRequired()
                    .HasColumnName("nama_user")
                    .HasMaxLength(25);

                entity.Property(e => e.Pswd)
                    .IsRequired()
                    .HasColumnName("pswd")
                    .HasMaxLength(20);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglData)
                    .HasColumnName("tgl_data")
                    .HasColumnType("date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.KdStsPenggunaNavigation)
                    .WithMany(p => p.IdentitasPengguna)
                    .HasForeignKey(d => d.KdStsPengguna)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("identitas_pengguna_kd_sts_pengguna_fkey");

                entity.HasOne(d => d.IdInstitusiNavigation)
                    .WithMany(p => p.IdentitasPengguna)
                    .HasForeignKey(d => d.IdInstitusi)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("identitas_pengguna_fk");

                entity.HasOne(d => d.IdPersonalNavigation)
                    .WithMany(p => p.IdentitasPengguna)
                    .HasForeignKey(d => d.IdPersonal)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("identitas_pengguna_id_personal_fkey");
            });

            modelBuilder.Entity<KelompokPeran>(entity =>
            {
                entity.HasKey(e => e.KdKelompokPeran)
                    .HasName("kelompok_peran_pkey");

                entity.ToTable("kelompok_peran", "pengguna");

                entity.Property(e => e.KdKelompokPeran)
                    .HasColumnName("kd_kelompok_peran")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.KdJenisInstitusi).HasColumnName("kd_jenis_institusi");

                entity.Property(e => e.KdTataranPengguna).HasColumnName("kd_tataran_pengguna");

                entity.Property(e => e.KelompokPeran1)
                    .HasColumnName("kelompok_peran")
                    .HasMaxLength(50);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.KdTataranPenggunaNavigation)
                    .WithMany(p => p.KelompokPeran)
                    .HasForeignKey(d => d.KdTataranPengguna)
                    .HasConstraintName("kelompok_peran_kd_tataran_pengguna_fkey");

                entity.HasOne(d => d.KdJenisInstitusiNavigation)
                    .WithMany(p => p.KelompokPeran)
                    .HasForeignKey(d => d.KdJenisInstitusi)
                    .HasConstraintName("kelompok_peran_kd_jenis_institusi_fkey");
            });

            modelBuilder.Entity<KontakPicPenggunaInstitusi>(entity =>
            {
                entity.HasKey(e => e.IdKontakPicPenggunaInstitusi)
                    .HasName("kontak_pic_pengguna_pkey");

                entity.ToTable("kontak_pic_pengguna_institusi", "pengguna");

                entity.HasIndex(e => e.IdInstitusi)
                    .HasName("kontak_pic_pengguna_institusi_id_institusi_idx");

                entity.HasIndex(e => new { e.IdInstitusi, e.KdJenisKegiatan })
                    .HasName("kontak_pic_pengguna_institusi_id_institusi_kd_jenis_kegiatan_ke")
                    .IsUnique();

                entity.Property(e => e.IdKontakPicPenggunaInstitusi)
                    .HasColumnName("id_kontak_pic_pengguna_institusi")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.IdInstitusi).HasColumnName("id_institusi");

                entity.Property(e => e.IdPeran).HasColumnName("id_peran");

                entity.Property(e => e.KdJenisKegiatan).HasColumnName("kd_jenis_kegiatan");

                entity.Property(e => e.Surel)
                    .HasColumnName("surel")
                    .HasMaxLength(100);

                entity.Property(e => e.Telepon)
                    .HasColumnName("telepon")
                    .HasMaxLength(20);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<LoginGagal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("login_gagal", "pengguna");

                entity.Property(e => e.IdPeran).HasColumnName("id_peran");

                entity.Property(e => e.IpKomputer)
                    .HasColumnName("ip_komputer")
                    .HasMaxLength(30);

                entity.Property(e => e.NamaUser)
                    .HasColumnName("nama_user")
                    .HasMaxLength(25);

                entity.Property(e => e.Pswd)
                    .HasColumnName("pswd")
                    .HasMaxLength(20);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.WaktuAkses).HasColumnName("waktu_akses");
            });

            modelBuilder.Entity<PengirimanUser>(entity =>
            {
                entity.HasKey(e => e.IdPengirimanUser)
                    .HasName("pengiriman_user_pkey");

                entity.ToTable("pengiriman_user", "pengguna");

                entity.HasIndex(e => new { e.IdKontakPicPenggunaInstitusi, e.Surel })
                    .HasName("pengiriman_user_p_id_kontak_pic_pengguna_institusi_surel_idx");

                entity.Property(e => e.IdPengirimanUser)
                    .HasColumnName("id_pengiriman_user")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.IdKontakPicPenggunaInstitusi).HasColumnName("id_kontak_pic_pengguna_institusi");

                entity.Property(e => e.IdPersonal).HasColumnName("id_personal");

                entity.Property(e => e.KdStsPengiriman)
                    .HasColumnName("kd_sts_pengiriman")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Surel)
                    .IsRequired()
                    .HasColumnName("surel")
                    .HasMaxLength(100);

                entity.Property(e => e.SurelPengirim)
                    .HasColumnName("surel_pengirim")
                    .HasMaxLength(100);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.WaktuPegiriman)
                    .HasColumnName("waktu_pegiriman")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.IdPersonalNavigation)
                    .WithMany(p => p.PengirimanUser)
                    .HasForeignKey(d => d.IdPersonal)
                    .HasConstraintName("id_personal_fkey");
            });

            modelBuilder.Entity<Peran>(entity =>
            {
                entity.HasKey(e => e.IdPeran)
                    .HasName("peran_pkey");

                entity.ToTable("peran", "pengguna");

                entity.HasIndex(e => e.IdPeran)
                    .HasName("peran_id_peran_idx");

                entity.Property(e => e.IdPeran)
                    .HasColumnName("id_peran")
                    .HasDefaultValueSql("nextval(('pengguna.peran_id_peran_seq'::text)::regclass)");

                entity.Property(e => e.KdKelompokPeran)
                    .HasColumnName("kd_kelompok_peran")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.KdStsAktif)
                    .HasColumnName("kd_sts_aktif")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Keterangan)
                    .HasColumnName("keterangan")
                    .HasMaxLength(255);

                entity.Property(e => e.NamaPeran)
                    .HasColumnName("nama_peran")
                    .HasMaxLength(50);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.KdKelompokPeranNavigation)
                    .WithMany(p => p.Peran)
                    .HasForeignKey(d => d.KdKelompokPeran)
                    .HasConstraintName("fk_peran_kelompok_peran");
            });

            modelBuilder.Entity<PeranOperator>(entity =>
            {
                entity.HasKey(e => e.IdPeranOperator)
                    .HasName("peran_operator_pkey");

                entity.ToTable("peran_operator", "pengguna");

                entity.Property(e => e.IdPeranOperator)
                    .HasColumnName("id_peran_operator")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.IdPeran).HasColumnName("id_peran");

                entity.Property(e => e.KdJenisKegiatan).HasColumnName("kd_jenis_kegiatan");

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.IdPeranNavigation)
                    .WithMany(p => p.PeranOperator)
                    .HasForeignKey(d => d.IdPeran)
                    .HasConstraintName("peran_operator_id_peran_fkey");
            });

            modelBuilder.Entity<PeranPengguna>(entity =>
            {
                entity.HasKey(e => new { e.IdPersonal, e.IdPeran })
                    .HasName("peran_pengguna_pkey");

                entity.ToTable("peran_pengguna", "pengguna");

                entity.HasIndex(e => e.IdPeran)
                    .HasName("peran_pengguna_id_peran_idx");

                entity.HasIndex(e => e.IdPersonal)
                    .HasName("peran_pengguna_id_personal_idx");

                entity.Property(e => e.IdPersonal).HasColumnName("id_personal");

                entity.Property(e => e.IdPeran).HasColumnName("id_peran");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("is_default")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KdStsPeranPengguna).HasColumnName("kd_sts_peran_pengguna");

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.IdPeranNavigation)
                    .WithMany(p => p.PeranPengguna)
                    .HasForeignKey(d => d.IdPeran)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("peran_pengguna_fk1");

                entity.HasOne(d => d.IdPersonalNavigation)
                    .WithMany(p => p.PeranPengguna)
                    .HasForeignKey(d => d.IdPersonal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("peran_pengguna_id_identitas_pengguna_fkey");

                entity.HasOne(d => d.KdStsPeranPenggunaNavigation)
                    .WithMany(p => p.PeranPengguna)
                    .HasForeignKey(d => d.KdStsPeranPengguna)
                    .HasConstraintName("peran_pengguna_kd_sts_peran_pengguna_fkey");
            });

            modelBuilder.Entity<Sertifikat>(entity =>
            {
                entity.HasKey(e => e.IdSertifikat)
                    .HasName("sertifikat_pkey");

                entity.ToTable("sertifikat", "pengguna");

                entity.HasIndex(e => e.IdPersonal)
                    .HasName("sertifikat_id_personal_idx");

                entity.HasIndex(e => e.IdSertifikat)
                    .HasName("sertifikat_id_sertifikat_idx");

                entity.Property(e => e.IdSertifikat)
                    .HasColumnName("id_sertifikat")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPersonal).HasColumnName("id_personal");

                entity.Property(e => e.IpKomputer)
                    .HasColumnName("ip_komputer")
                    .HasMaxLength(30);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.WaktuAksesTerakhir).HasColumnName("waktu_akses_terakhir");

                entity.Property(e => e.WaktuLogin)
                    .HasColumnName("waktu_login")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.IdPersonalNavigation)
                    .WithMany(p => p.Sertifikat)
                    .HasForeignKey(d => d.IdPersonal)
                    .HasConstraintName("sertifikat_id_identitas_pengguna_fkey");
            });

            modelBuilder.Entity<StatusPengguna>(entity =>
            {
                entity.HasKey(e => e.KdStsPengguna)
                    .HasName("kd_sts_pengguna_pkey");

                entity.ToTable("status_pengguna", "pengguna");

                entity.Property(e => e.KdStsPengguna)
                    .HasColumnName("kd_sts_pengguna")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusPengguna1)
                    .HasColumnName("status_pengguna")
                    .HasMaxLength(10);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<StatusPeranPengguna>(entity =>
            {
                entity.HasKey(e => e.KdStsPeranPengguna)
                    .HasName("status_peran_pengguna_pkey");

                entity.ToTable("status_peran_pengguna", "pengguna");

                entity.Property(e => e.KdStsPeranPengguna)
                    .HasColumnName("kd_sts_peran_pengguna")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusPeranPengguna1)
                    .HasColumnName("status_peran_pengguna")
                    .HasMaxLength(10);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<TataranPengguna>(entity =>
            {
                entity.HasKey(e => e.KdTataranPengguna)
                    .HasName("tataran_pengguna_pkey");

                entity.ToTable("tataran_pengguna", "pengguna");

                entity.Property(e => e.KdTataranPengguna)
                    .HasColumnName("kd_tataran_pengguna")
                    .ValueGeneratedNever();

                entity.Property(e => e.TataranPengguna1)
                    .HasColumnName("tataran_pengguna")
                    .HasMaxLength(15);

                entity.Property(e => e.TglCreated)
                    .HasColumnName("tgl_created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TglUpdated)
                    .HasColumnName("tgl_updated")
                    .HasDefaultValueSql("now()");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
