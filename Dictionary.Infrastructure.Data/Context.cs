using System;
using System.Collections.Generic;
using System.Text;
using Dictionary.Domain.Core;
using Dictionary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Dictionary.Infrastructure.Data
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<EstLang> EstLangs { get; set; }
        public DbSet<EngLang> EngLangs { get; set; }
        public DbSet<RusLang> RusLangs { get; set; }
        public DbSet<TranslEngEst> TranslEngEsts { get; set; }
        public DbSet<TranslEngRus> TranslEngRuses { get; set; }
        public DbSet<TranslRusEst> TranslRusEsts { get; set; }
        public DbSet<PartOfSpeech> PartsOfSpeech { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {

        //        optionsBuilder.UseSqlServer(@"Server=mail.vk.edu.ee\SQLEXPRESS;Database=db_Elonen; user id=t143264;password=t143264");
        //    }
        //}
        //public Context(string connectionstring) { }
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options)

        { } //NB!! The constructor above will allow configuration to be passed into the context by dependency injection.
            //

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.ToTable("t_category", "dict");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasColumnName("categoryname")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EngLang>(entity =>
            {
                entity.HasKey(e => e.IdWord);

                entity.ToTable("t_langenglish", "dict");

                entity.HasIndex(e => e.Word)
                    .HasName("UQ__t_langen__839740544226FE4E")
                    .IsUnique();

                entity.Property(e => e.IdWord).HasColumnName("id_word");

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasColumnName("word")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstLang>(entity =>
            {
                entity.HasKey(e => e.IdWord);

                entity.ToTable("t_langestonian", "dict");

                entity.HasIndex(e => e.Word)
                    .HasName("UQ__t_langes__83974054B2E114E4")
                    .IsUnique();

                entity.Property(e => e.IdWord).HasColumnName("id_word");

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasColumnName("word")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RusLang>(entity =>
            {
                entity.HasKey(e => e.IdWord);

                entity.ToTable("t_langrussian", "dict");

                entity.HasIndex(e => e.Word)
                    .HasName("UQ__t_langru__83974054818D321F")
                    .IsUnique();

                entity.Property(e => e.IdWord).HasColumnName("id_word");

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasColumnName("word")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PartOfSpeech>(entity =>
            {
                entity.HasKey(e => e.IdPart);

                entity.ToTable("t_partofspeech", "dict");

                entity.Property(e => e.IdPart).HasColumnName("id_part");

                entity.Property(e => e.Partname)
                    .IsRequired()
                    .HasColumnName("partname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Subcategory>(entity =>
            {
                entity.HasKey(e => e.IdSubcategory);

                entity.ToTable("t_subcategory", "dict");

                entity.Property(e => e.IdSubcategory).HasColumnName("id_subcategory");

                entity.Property(e => e.categoryID).HasColumnName("id_category");
                //entity.HasOne(e => e.Category).WithMany(o => o.Subcategories); .HasColumnName("id_category");

                

                entity.Property(e => e.Subcategoryname)
                    .IsRequired()
                    .HasColumnName("subcategoryname")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Subcategories)
                    .HasForeignKey(d => d.categoryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_category_subcategory");
            });




            modelBuilder.Entity<TranslEngEst>(entity =>
            {
                entity.HasKey(e => e.IdTranslation);

                entity.ToTable("t_translation_eng_est", "dict");

                entity.Property(e => e.IdTranslation).HasColumnName("id_translation");

                entity.Property(e => e.Example)
                    .HasColumnName("example")
                    .HasColumnType("ntext");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdPart).HasColumnName("id_part");

                entity.Property(e => e.IdWordEng).HasColumnName("id_word_eng");

                entity.Property(e => e.IdWordEst).HasColumnName("id_word_est");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.TranslEngEst)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("fk_translation_eng_est_category");

                entity.HasOne(d => d.PartOfSpeech)
                    .WithMany(p => p.TranslEngEst)
                    .HasForeignKey(d => d.IdPart)
                    .HasConstraintName("fk_translation_eng_est_part");

                entity.HasOne(d => d.EngWord)
                    .WithMany(p => p.TranslEngEsts)
                    .HasForeignKey(d => d.IdWordEng)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_translation_eng_est_engword");

                entity.HasOne(d => d.EstWord)
                    .WithMany(p => p.TranslEngEsts)
                    .HasForeignKey(d => d.IdWordEst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_translation_eng_est_estword");
            });

            modelBuilder.Entity<TranslEngRus>(entity =>
            {
                entity.HasKey(e => e.IdTranslation);

                entity.ToTable("t_translation_eng_rus", "dict");

                entity.Property(e => e.IdTranslation).HasColumnName("id_translation");

                entity.Property(e => e.Example)
                    .HasColumnName("example")
                    .HasColumnType("ntext");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdPart).HasColumnName("id_part");

                entity.Property(e => e.IdWordEng).HasColumnName("id_word_eng");

                entity.Property(e => e.IdWordRus).HasColumnName("id_word_rus");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.TranslEngRus)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("fk_translation_eng_rus_category");

                entity.HasOne(d => d.PartOfSpeech)
                    .WithMany(p => p.TranslEngRus)
                    .HasForeignKey(d => d.IdPart)
                    .HasConstraintName("fk_translation_eng_rus_part");

                entity.HasOne(d => d.EngWord)
                    .WithMany(p => p.TranslEngRuses)
                    .HasForeignKey(d => d.IdWordEng)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_translation_eng_rus_engword");

                entity.HasOne(d => d.RusWord)
                    .WithMany(p => p.TranslEngRuses)
                    .HasForeignKey(d => d.IdWordRus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_translation_eng_rus_rusword");
            });

            modelBuilder.Entity<TranslRusEst>(entity =>
            {
                entity.HasKey(e => e.IdTranslation);

                entity.ToTable("t_translation_rus_est", "dict");

                entity.Property(e => e.IdTranslation).HasColumnName("id_translation");

                entity.Property(e => e.Example)
                    .HasColumnName("example")
                    .HasColumnType("ntext");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdPart).HasColumnName("id_part");

                entity.Property(e => e.IdWordEst).HasColumnName("id_word_est");

                entity.Property(e => e.IdWordRus).HasColumnName("id_word_rus");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.TranslRusEst)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("fk_translation_rus_est_category");

                entity.HasOne(d => d.PartOfSpeech)
                    .WithMany(p => p.TranslRusEst)
                    .HasForeignKey(d => d.IdPart)
                    .HasConstraintName("fk_translation_rus_est_part");

                entity.HasOne(d => d.EstWord)
                    .WithMany(p => p.TranslRusEst)
                    .HasForeignKey(d => d.IdWordEst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_translation_rus_est_estword");

                entity.HasOne(d => d.RusWord)
                    .WithMany(p => p.TranslRusEsts)
                    .HasForeignKey(d => d.IdWordRus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_translation_rus_est_rusword");
            });
        }
    }
}
