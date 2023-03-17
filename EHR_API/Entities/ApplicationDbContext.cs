using EHR_API.Entities.Models;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Entities.ModelsConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EHR_API.Entities
{
    public class ApplicationDbContext : IdentityDbContext<RegistrationData>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            InitalizeContext();
        }

        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<HealthFacility> HealthFacilities { get; set; }
        public DbSet<ICD> ICDs { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<AllergyDrug> AllergyDrugs { get; set; }
        public DbSet<UserInsurance> UserInsurances { get; set; }
        public DbSet<ChronicDisease> ChronicDiseases { get; set; }
        public DbSet<ChronicDiseaseDrug> ChronicDiseaseDrugs { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<UserVaccination> UserVaccinations { get; set; }
        public DbSet<BadHabit> BadHabits { get; set; }
        public DbSet<MedicalFacilityTeam> MedicalFacilityTeams { get; set; }
        public DbSet<Contraindication> Contraindications { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<VisitVitalSign> VisitVitalSigns { get; set; }
        public DbSet<VisitMedication> VisitMedications { get; set; }
        public DbSet<RadLabResultImage> RadLabResultImages { get; set; }
        public DbSet<VisitRadLabTest> VisitRadLabTests { get; set; }
        public DbSet<Admit> Admits { get; set; }
        public DbSet<Surgery> Surgeries { get; set; }
        public DbSet<SurgeryProgressNote> SurgeryProgressNotes { get; set; }
        public DbSet<BloodDonation> BloodDonations { get; set; }
        public DbSet<ReceiveBlood> ReceiveBloods { get; set; }
        public DbSet<ReceiveBloodData> Receives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ApplyConfiguration
            modelBuilder.ApplyConfiguration(new GovernorateConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new HealthFacilityConfiguration());
            modelBuilder.ApplyConfiguration(new ICDConfiguration());
            modelBuilder.ApplyConfiguration(new UserInsuranceConfiguration());
            modelBuilder.ApplyConfiguration(new PersonalDataConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalDataConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalTeamConfiguration());
            modelBuilder.ApplyConfiguration(new MedicationConfiguration());
            modelBuilder.ApplyConfiguration(new BloodDonationConfiguration());
            modelBuilder.ApplyConfiguration(new BadHabitConfiguration());
            modelBuilder.ApplyConfiguration(new AllergyConfiguration());
            modelBuilder.ApplyConfiguration(new AllergyDrugConfiguration());
            modelBuilder.ApplyConfiguration(new VaccinationConfiguration());

            //one-to-one
            modelBuilder.Entity<RegistrationData>()
               .HasOne(a => a.PersonalData)
               .WithOne(r => r.RegistrationData)
               .HasForeignKey<PersonalData>(p => p.Id);

            modelBuilder.Entity<RegistrationData>()
               .HasOne(a => a.MedicalData)
               .WithOne(r => r.RegistrationData)
               .HasForeignKey<MedicalData>(m => m.Id);

            modelBuilder.Entity<RegistrationData>()
               .HasOne(m => m.MedicalTeam)
               .WithOne(r => r.RegistrationData)
               .HasForeignKey<MedicalTeam>(m => m.Id);

            modelBuilder.Entity<Admit>()
           .HasAlternateKey(c => c.VisitId)
           .HasName("AlternateKey_VisitId");

            modelBuilder.Entity<Visit>()
             .HasOne(a => a.Admit)
             .WithOne(i => i.Visit)
             .HasForeignKey<Admit>(i => i.VisitId);

            /* composite key
            //modelBuilder.Entity<AllergyDrug>()
            //    .HasKey(a => new { a.AllergyId, a.MedicationId });

            //modelBuilder.Entity<ChronicDisease>()
            // .HasKey(a => new { a.RegistrationDataId, a.ICDId });

            //modelBuilder.Entity<ChronicDiseaseDrug>()
            //   .HasKey(a => new { a.RegistrationDataId, a.ICDId, a.MedicationId });

            //modelBuilder.Entity<Contraindication>()
            //   .HasKey(a => new { a.MedicationId, a.RegistrationDataId });

            //modelBuilder.Entity<MedicalFacilityTeam>()
            // .HasKey(a => new { a.HealthFacilityId, a.MedicalTeamId });

            //modelBuilder.Entity<VisitMedication>()
            // .HasKey(a => new { a.MedicationId, a.VisitId });
            */

            // two columns unique
            modelBuilder.Entity<UserVaccination>()
                .HasIndex(p => new { p.VisitId, p.VaccinationId }).IsUnique();

            modelBuilder.Entity<AllergyDrug>()
                .HasIndex(p => new { p.AllergyId, p.MedicationId }).IsUnique();

            modelBuilder.Entity<ChronicDisease>()
                .HasIndex(p => new { p.RegistrationDataId, p.ICDId }).IsUnique();

            modelBuilder.Entity<ChronicDiseaseDrug>()
                .HasIndex(p => new { p.RegistrationDataId, p.ICDId, p.MedicationId }).IsUnique();

            modelBuilder.Entity<Contraindication>()
                .HasIndex(p => new { p.RegistrationDataId, p.MedicationId }).IsUnique();

            modelBuilder.Entity<MedicalFacilityTeam>()
                .HasIndex(p => new { p.HealthFacilityId, p.MedicalTeamId }).IsUnique();

            modelBuilder.Entity<VisitMedication>()
                .HasIndex(p => new { p.MedicationId, p.VisitId }).IsUnique();
        }


        protected virtual void InitalizeContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            Database.SetCommandTimeout(360);
        }
    }
}
