using scanner.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scanner.Contexts
{
    public partial class MainContext : DbContext  
    {
        #region Fields
        private static MainContext _mainContext;
//        private static Logger _logger = LogManager.GetCurrentClassLogger();

//        private const string UNEXPECTED_BEHAVIOR = @"Συνέβη κάποια απρόσμενη ενέργεια.";

//        private const string CONTACT_SUPPORT = @"Παρακαλώ επικοινωνήστε άμεσα με το Τμήμα Εξυπηρέτησης Πελατών
//της Sigmasoft στα τηλέφωνα:
//801-1165100, 210-7248719, 2310-935340, 2310905470, 2310-935490.";

//        public static readonly string GENERAL_ERROR = UNEXPECTED_BEHAVIOR + Environment.NewLine + CONTACT_SUPPORT;

//        private const string DATA_SOURCE = "Data Source = {0}\\{1}.sdf;Max Database Size=4091;Password=A4$dJkIdsfM@#9$5656Uc";
//        //private const string DATA_SOURCE = "Data Source=.;Initial Catalog=MedExpress-ByConnectionString;Integrated Security=true;\" providerName=\"System.Data.SqlClient";
//        //private const string DATA_SOURCE = @"Data source=.\SQLEXPRESS01; initial catalog=MEDEXPRESS;persist security info=True; Integrated Security=SSPI;"; // SQL SERVER EXPRESS CONNECTION STRING
//        private string _applicationName = "MedClinic";
        #endregion

        public MainContext()
            : base("name=MainContext")
        {
            try
            {
                this.Configuration.LazyLoadingEnabled = true;//true;
                this.Configuration.ProxyCreationEnabled = false;//false;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        static MainContext()
        {
            try
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<MainContext, Configuration>());
                //Database.SetInitializer(new CreateDatabaseIfNotExists<MedContext>());
                //_logger.Info("----- MedClinicContext().Database.SetInitializer Completed. -----");

                using (MainContext db = new MainContext())
                {
                    try
                    {
                        db.Database.Initialize(false);
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
            }
            catch (System.Exception ex)
            {
                
            }
        }

        public static MainContext Instance
        {
            get
            {
                _mainContext = new MainContext();
                return _mainContext;
            }
        }

        public void Update()
        {
            try
            {
                //var configuration = new DbMigrationsConfiguration();
                //configuration.TargetDatabase = new DbConnectionInfo(
                //    Database.Connection.ConnectionString, "System.Data.SqlServerCe.4.0");

                //var migrator = new DbMigrator(configuration);
                //migrator.Update();
                //migrator.GetPendingMigrations();
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<MainContext, Configuration>());
            }
            catch (System.Exception ex)
            {
                //_logger.ErrorException("Update", ex);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DoctorUnion>()
            //    .HasOptional<City>(s => s.CityState);

            ////one-to-many 
            //modelBuilder.Entity<MedicineDisease>()
            //            .HasRequired<Medicine>(s => s.Medicine)
            //            .WithMany(s => s.MedicineDiseases)
            //            .HasForeignKey(s => s.MedicineId);

            ////one-to-many
            //modelBuilder.Entity<MedicineDisease>()
            //    .HasRequired<Disease>(s => s.Disease)
            //    .WithMany(s => s.MedicineDiseases)
            //    .HasForeignKey(m => m.DiseaseId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<SpcFilterIcd10>()
            //    .HasRequired<Icd10Diagnosis>(p => p.ICD10)
            //    .WithMany()
            //    .HasForeignKey(f => f.Icd10ID);

            ////one-to-many
            //modelBuilder.Entity<SpcFilterIcd10>()
            //    .HasRequired<SpcFilter>(s => s.SpcFilter)
            //    .WithMany(s => s.SpcFilterIcd10Collection)
            //    .HasForeignKey(m => m.SpcFilterId)
            //    .WillCascadeOnDelete(false);

            ////one-to-many 
            //modelBuilder.Entity<Examination>()
            //            .HasRequired<ExaminationGroup>(s => s.ExaminationGroup)
            //            .WithMany(s => s.Examinations)
            //            .HasForeignKey(s => s.ExaminationGroupId);

            ////many-to-many
            //modelBuilder.Entity<ICPC2>()
            //   .HasMany<Visit>(i => i.Visits);
            ////many-to-many
            //modelBuilder.Entity<Visit>()
            //   .HasMany<ICPC2>(i => i.ICPC2Collection);

            //// Visit
            ////one-to-many 
            //modelBuilder.Entity<Visit>()
            //            .HasOptional<VisitStatus>(s => s.VisitStatus)
            //            .WithMany(s => s.Visits)
            //            .HasForeignKey(s => s.VisitStatusId);

            ////one-to-many
            //modelBuilder.Entity<Visit>()
            //    .HasOptional<Icd10FirstLevel>(s => s.Icd10Voucher)
            //    .WithMany(s => s.Visits)
            //    .HasForeignKey(m => m.Icd10VoucherId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Visit>()
            //    .HasRequired<Patient>(p => p.VisitPatient)
            //    .WithMany()
            //    .HasForeignKey(f => f.PatientId);

            //modelBuilder.Entity<Prescription>()
            //    .HasRequired<Patient>(p => p.Patient)
            //    .WithMany()
            //    .HasForeignKey(f => f.PatientId);

            //modelBuilder.Entity<Prescription>()
            //    .HasRequired<Visit>(p => p.Visit)
            //    .WithMany()
            //    .HasForeignKey(f => f.VisitId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Referral>()
            //    .HasRequired<Patient>(p => p.Patient)
            //    .WithMany()
            //    .HasForeignKey(f => f.PatientId);
            ////one-to-many
            //modelBuilder.Entity<Visit>()
            //    .HasOptional<DapyRecord>(s => s.DapyRecord)
            //    .WithMany(s => s.Visits)
            //    .HasForeignKey(m => m.DapyRecordId)
            //    .WillCascadeOnDelete(false);

            ////one-to-many
            //modelBuilder.Entity<DapyRecord>()
            //    .HasOptional<DapySubmissionPeriod>(s => s.SubmissionPeriod)
            //    .WithMany(s => s.DapyRecords)
            //    .HasForeignKey(m => m.SubmissionPeriodId)
            //    .WillCascadeOnDelete(true);

            ////one-to-many
            //modelBuilder.Entity<PatientInsurance>()
            //    .HasRequired<Patient>(s => s.Patient)
            //    .WithMany(s => s.PatientInsurances)
            //    .HasForeignKey(m => m.PatientId)
            //    .WillCascadeOnDelete(true);

            ////Referral 
            ////one-to-many 
            //modelBuilder.Entity<Referral>()
            //            .HasOptional<SocialInsurance>(s => s.SocialInsurance)
            //            .WithMany(s => s.Referrals)
            //            .HasForeignKey(s => s.SocialInsuranceId);

            ////one-to-many
            //modelBuilder.Entity<Referral>()
            //    .HasOptional<CustomDiagnosis>(s => s.CustomDiagnosis)
            //    .WithMany(s => s.Referrals)
            //    .HasForeignKey(m => m.CustomDiagnosisId)
            //    .WillCascadeOnDelete(false);
            ////one-to-many
            //modelBuilder.Entity<Prescription>()
            //    .HasOptional<CustomDiagnosis>(s => s.CustomDiagnosis)
            //    .WithMany(s => s.Prescriptions)
            //    .HasForeignKey(m => m.CustomDiagnosisId)
            //    .WillCascadeOnDelete(false);

            ////one-to-many
            //modelBuilder.Entity<MedicineDosage>()
            //    .HasRequired<Treatment>(s => s.Treatment)
            //    .WithMany(s => s.MedicinesDosage)
            //    .HasForeignKey(m => m.TreatmentId)
            //    .WillCascadeOnDelete(true);

            ////one-to-many 
            //modelBuilder.Entity<MedicineDosage>()
            //            .HasOptional<Medicine>(s => s.PrescribedMedicine)
            //            .WithMany()
            //            .HasForeignKey(s => s.PrescribedMedicineId);

            //modelBuilder.Entity<MedicineDosage>()
            //            .HasOptional<Medicine>(s => s.RedeemedMedicine)
            //            .WithMany()
            //            .HasForeignKey(s => s.RedeemedMedicineId);

            ////one-to-many
            //modelBuilder.Entity<ExecutedMedicineDosage>()
            //    .HasRequired<MedicineDosage>(s => s.MedicineDosage)
            //    .WithMany(s => s.ExecutedMedicineDosages)
            //    .HasForeignKey(m => m.MedicineDosageId)
            //    .WillCascadeOnDelete(true);

            //// many-to-many
            //modelBuilder.Entity<MedicineDosage>()
            //   .HasMany<Icd10Diagnosis>(i => i.Icd10Diagnoses)
            //   .WithMany(i => i.MedicineDosages);

            ////one-to-many
            //modelBuilder.Entity<Referral>()
            //            .HasRequired<Visit>(s => s.Visit)
            //            .WithMany()
            //            .HasForeignKey(m => m.VisitId)
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<ReferralExamination>()
            //            .HasRequired(r => r.Referral)
            //            .WithMany(s => s.ReferralExaminationCollection)
            //            .HasForeignKey(r => r.ReferralId)
            //            .WillCascadeOnDelete(false);

            ////many - to - many
            //modelBuilder.Entity<Referral>()
            //   .HasMany<Icd10Diagnosis>(i => i.Icd10Diagnoses)
            //.WithMany(i => i.Referrals);

            ////many-to-many
            //modelBuilder.Entity<Prescription>()
            //   .HasMany<Icd10Diagnosis>(i => i.Icd10Diagnoses)
            //   .WithMany(i => i.Prescriptions);

            //modelBuilder.Entity<Appointment>()
            //            .HasOptional<Patient>(s => s.Patient)
            //            .WithMany()
            //            .HasForeignKey(s => s.PatientId);

            ////Prescription
            ////one - to - one
            //modelBuilder.Entity<Prescription>()
            //            .HasRequired<Visit>(s => s.Visit)
            //            .WithMany()
            //            .HasForeignKey(m => m.VisitId)
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Prescription>()
            //            .HasOptional<PrescriptionStatus>(s => s.PrescriptionStatus)
            //            .WithMany()
            //            .HasForeignKey(s => s.PrescriptionStatusId);

            ////one - to - many
            //modelBuilder.Entity<FileComment>()
            //    .HasRequired<Patient>(s => s.FilePatient)
            //    .WithMany(s => s.FileComments)
            //    .HasForeignKey(m => m.PatientId)
            //    .WillCascadeOnDelete(false);// todo check

            //modelBuilder.Entity<Receipt>()
            //    .HasRequired<Patient>(s => s.Patient)
            //    .WithMany(s => s.Receipts)
            //    .HasForeignKey(m => m.PatientId)
            //    .WillCascadeOnDelete(false);// todo check

            //modelBuilder.Entity<City>()
            //    .HasOptional<County>(s => s.County)
            //    .WithMany(s => s.Cities)
            //    .HasForeignKey(m => m.CountyId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<County>()
            //    .HasOptional<Country>(s => s.Country)
            //    .WithMany(s => s.Counties)
            //    .HasForeignKey(m => m.CountryId)
            //    .WillCascadeOnDelete(false);

            //// PATIENT SUMMARY

            ////many - to - many
            //modelBuilder.Entity<Allergy>()
            //   .HasMany<Medicine>(i => i.BrandMedicines)
            //    .WithMany(i => i.BrandMedicines);

            ////many - to - many
            //modelBuilder.Entity<Allergy>()
            //   .HasMany<Medicine>(i => i.ActiveSubstanceMedicines)
            //    .WithMany(i => i.ActiveSubstanceMedicines);

            //// One to many
            //modelBuilder.Entity<ExaminationResult>()
            //.HasRequired<Patient>(s => s.Patient)
            //.WithMany()
            //.HasForeignKey(m => m.PatientId)
            //.WillCascadeOnDelete(false);

            //// One to one with cascade on Delete
            //modelBuilder.Entity<CompletedBlood>()
            //.HasKey(t => t.ExaminationResultId);

            //modelBuilder.Entity<ExaminationResult>()
            //.HasRequired(t => t.CompletedBlood)
            //.WithRequiredPrincipal(t => t.ExaminationResult)
            //.WillCascadeOnDelete(true);

            //// One to one with cascade on Delete
            //modelBuilder.Entity<Biochemical>()
            //.HasKey(t => t.ExaminationResultId);

            //modelBuilder.Entity<ExaminationResult>()
            //.HasRequired(t => t.Biochemical)
            //.WithRequiredPrincipal(t => t.ExaminationResult)
            //.WillCascadeOnDelete(true);

            //// One to one with cascade on Delete
            //modelBuilder.Entity<Urine>()
            //.HasKey(t => t.ExaminationResultId);

            //modelBuilder.Entity<ExaminationResult>()
            //.HasRequired(t => t.Urine)
            //.WithRequiredPrincipal(t => t.ExaminationResult)
            //.WillCascadeOnDelete(true);

            //// One to one with cascade on Delete
            //modelBuilder.Entity<OtherExamination>()
            //.HasKey(t => t.ExaminationResultId);

            //modelBuilder.Entity<ExaminationResult>()
            //.HasRequired(t => t.OtherExamination)
            //.WithRequiredPrincipal(t => t.ExaminationResult)
            //.WillCascadeOnDelete(true);

            ////many - to - many
            //modelBuilder.Entity<Allergy>()
            //   .HasMany<FoodAllergy>(i => i.FoodAllergies)
            //    .WithMany(i => i.FoodAllergies);

            ////many - to - many
            //modelBuilder.Entity<Allergy>()
            //   .HasMany<Allergen>(i => i.Allergens)
            //    .WithMany(i => i.Allergens);

            //// One to many
            //modelBuilder.Entity<FamilyMember>()
            //.HasRequired<Patient>(s => s.Patient)
            //.WithMany()
            //.HasForeignKey(m => m.PatientId)
            //.WillCascadeOnDelete(false);

            //// One to one with cascade on Delete
            //modelBuilder.Entity<FamilyDetailsMember>()
            //.HasKey(t => t.FamilyMemberId);

            //modelBuilder.Entity<FamilyMember>()
            //.HasRequired(t => t.FamilyDetailsMember)
            //.WithRequiredPrincipal(t => t.FamilyMember)
            //.WillCascadeOnDelete(true);

            ////OverrideType
            ////many - to - many
            //modelBuilder.Entity<OverrideType>()
            //   .HasMany<SocialInsuranceOverride>(i => i.SocialInsuranceOverrides)
            //.WithMany(i => i.OverrideTypes);

            //#region FinancialManagement
            //modelBuilder.Entity<DocumentSeriesNumber>()
            //.HasRequired<DocumentType>(s => s.DocumentType)
            //.WithMany()
            //.HasForeignKey(m => m.DocumentTypeId)
            //.WillCascadeOnDelete(true);

            //modelBuilder.Entity<DocumentSeriesNumber>()
            //.HasRequired<DocumentSeries>(s => s.DocumentSeries)
            //.WithMany()
            //.HasForeignKey(m => m.DocumentSeriesId)
            //.WillCascadeOnDelete(true);

            //modelBuilder.Entity<DocumentTypeLine>()
            //.HasRequired<DocumentLine>(s => s.DocumentLine)
            //.WithMany()
            //.HasForeignKey(m => m.DocumentLineId)
            //.WillCascadeOnDelete(true);

            //modelBuilder.Entity<DocumentTypeLine>()
            //.HasRequired<DocumentType>(s => s.DocumentType)
            //.WithMany()
            //.HasForeignKey(m => m.DocumentTypeId)
            //.WillCascadeOnDelete(false);

            //modelBuilder.Entity<DocumentDetail>()
            //.HasRequired<Document>(s => s.Document)
            //.WithMany(s => s.DocumentDetails)
            //.HasForeignKey(m => m.DocumentId)
            //.WillCascadeOnDelete(true);

            //modelBuilder.Entity<DocumentDetail>()
            //.HasRequired<DocumentLine>(s => s.DocumentLine)
            //.WithMany()
            //.HasForeignKey(m => m.DocumentLineId)
            //.WillCascadeOnDelete(true);

            //modelBuilder.Entity<Document>()
            //    .HasRequired<DocumentSeriesNumber>(s => s.DocumentSeriesNumber)
            //    .WithMany()
            //    .HasForeignKey(m => m.DocumentSeriesNumberId)
            //    .WillCascadeOnDelete(true);

            //modelBuilder.Entity<Document>()
            //    .HasMany<Visit>(i => i.Visits)
            //    .WithMany(i => i.FinancialDocuments)
            //    .Map(ii =>
            //    {
            //        ii.MapLeftKey("ID_DOCUMENT");
            //        ii.MapRightKey("ID_VISIT");
            //        ii.ToTable("FIN_DOCUMENTS_VISITS");
            //    });
            //#endregion

            //#region SmartRX
            ////one-to-many
            //modelBuilder.Entity<SmartRXTempDosage>()
            //    .HasRequired<SmartRXTempPrescription>(s => s.SmartRXTempPrescription)
            //    .WithMany(s => s.SmartRXTempDosages)
            //    .HasForeignKey(m => m.SmartRXTempPrescriptionId)
            //    .WillCascadeOnDelete(true);
            //#endregion

            //#region MedClinic
            //modelBuilder.Entity<MedClinicDoctor>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicFileComment>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicFileComment>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicPrescription>()
            //           .HasRequired(c => c.MedClinicDoctor)
            //           .WithMany()
            //           .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicPrescription>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicCustomDiagnosis>()
            //           .HasRequired(c => c.MedClinicDoctor)
            //           .WithMany()
            //           .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicCustomDiagnosis>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicReferral>()
            //           .HasRequired(c => c.MedClinicDoctor)
            //           .WithMany()
            //           .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicReferral>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicOverrideReason>()
            //          .HasRequired(c => c.MedClinicDoctor)
            //          .WithMany()
            //          .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicOverrideReason>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicVisit>()
            //         .HasRequired(c => c.MedClinicDoctor)
            //         .WithMany()
            //         .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicVisit>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDapySubmissionPeriod>()
            //         .HasRequired(c => c.MedClinicDoctor)
            //         .WithMany()
            //         .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicDapySubmissionPeriod>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicDocumentSeriesNumber>()
            //        .HasRequired(c => c.MedClinicDoctor)
            //        .WithMany()
            //        .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicDocumentSeriesNumber>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDocumentSeries>()
            //        .HasRequired(c => c.MedClinicDoctor)
            //        .WithMany()
            //        .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicDocumentSeries>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDocumentType>()
            //       .HasRequired(c => c.MedClinicDoctor)
            //       .WithMany()
            //       .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicDocumentType>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicUserUnit>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicReceipt>()
            //      .HasRequired(c => c.MedClinicDoctor)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicReceipt>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicApiSave>()
            //      .HasRequired(c => c.MedClinicDoctor)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicApiSave>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicAppointmentCategory>()
            //      .HasRequired(c => c.MedClinicDoctor)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicAppointmentCategory>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicAppointment>()
            //      .HasRequired(c => c.MedClinicDoctor)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicAppointment>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicCalendarSync>()
            //      .HasRequired(c => c.MedClinicDoctor)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicCalendarSync>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicComment>()
            //      .HasRequired(c => c.MedClinicDoctor)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);


            //modelBuilder.Entity<MedClinicComment>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDocumentTypeLine>()
            //      .HasRequired(c => c.MedClinicDoctor)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDocumentTypeLine>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEdapyReceipt>()
            //      .HasRequired(c => c.MedClinicDoctor)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEdapyReceipt>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyExamination>()
            //     .HasRequired(c => c.MedClinicDoctor)
            //     .WithMany()
            //     .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyExamination>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyReferralEntry>()
            //     .HasRequired(c => c.MedClinicDoctor)
            //     .WithMany()
            //     .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyReferralEntry>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyReferralExaminationDetail>()
            //     .HasRequired(c => c.MedClinicDoctor)
            //     .WithMany()
            //     .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyReferralExaminationDetail>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyReferralExamination>()
            //     .HasRequired(c => c.MedClinicDoctor)
            //     .WithMany()
            //     .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyReferralExamination>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyReferral>()
            //     .HasRequired(c => c.MedClinicDoctor)
            //     .WithMany()
            //     .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyReferral>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyResultBeanEPrescription>()
            //     .HasRequired(c => c.MedClinicDoctor)
            //     .WithMany()
            //     .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicEopyyResultBeanEPrescription>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicMineExamination>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicNoSyncEntity>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicNoSyncEntity>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicReason>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicReason>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicReferralOverrideReason>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicReferralOverrideReason>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicSetting>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicSmartRXTempPrescription>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicSmartRXTempPrescription>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicSynchronization>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicSynchronization>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicVisitFavoriteReason>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicVisitFavoriteReason>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicVisitReason>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicVisitReason>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDocumentLine>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDocumentLine>()
            //            .HasRequired(c => c.MedClinicDoctor)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDapyRecord>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDapyRecord>()
            //             .HasRequired(c => c.MedClinicDoctor)
            //             .WithMany()
            //             .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDocument>()
            //            .HasRequired(c => c.MedClinicUser)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MedClinicDocument>()
            //             .HasRequired(c => c.MedClinicDoctor)
            //             .WithMany()
            //             .WillCascadeOnDelete(false);

            //#endregion
        }

    }
}
