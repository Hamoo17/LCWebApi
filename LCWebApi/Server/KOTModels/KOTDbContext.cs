using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class KOTDbContext : DbContext
    {
        public KOTDbContext()
        {
        }

        public KOTDbContext(DbContextOptions<KOTDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Allsave> Allsaves { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AutoDislike> AutoDislikes { get; set; }
        public virtual DbSet<Bagre> Bagres { get; set; }
        public virtual DbSet<Bagre2> Bagre2s { get; set; }
        public virtual DbSet<BagreD> BagreDs { get; set; }
        public virtual DbSet<Bagrech> Bagreches { get; set; }
        public virtual DbSet<Bagrech2> Bagrech2s { get; set; }
        public virtual DbSet<Bagrer> Bagrers { get; set; }
        public virtual DbSet<BillItemDetail> BillItemDetails { get; set; }
        public virtual DbSet<BillRecored> BillRecoreds { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Chashir> Chashirs { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Clincp> Clincps { get; set; }
        public virtual DbSet<Clncserv> Clncservs { get; set; }
        public virtual DbSet<Custinvoice> Custinvoices { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerPlan> CustomerPlans { get; set; }
        public virtual DbSet<CustomerPlansSh> CustomerPlansShes { get; set; }
        public virtual DbSet<CustomersExpiration> CustomersExpirations { get; set; }
        public virtual DbSet<CustomersLocation> CustomersLocations { get; set; }
        public virtual DbSet<D> Ds { get; set; }
        public virtual DbSet<D1> D1s { get; set; }
        public virtual DbSet<D2> D2s { get; set; }
        public virtual DbSet<D3> D3s { get; set; }
        public virtual DbSet<D4> D4s { get; set; }
        public virtual DbSet<D5> D5s { get; set; }
        public virtual DbSet<D6> D6s { get; set; }
        public virtual DbSet<D7> D7s { get; set; }
        public virtual DbSet<D8> D8s { get; set; }
        public virtual DbSet<D9> D9s { get; set; }
        public virtual DbSet<DailyDeliveryOrder> DailyDeliveryOrders { get; set; }
        public virtual DbSet<DailyUpdate> DailyUpdates { get; set; }
        public virtual DbSet<Dailyreo> Dailyreos { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<DeliveryPrint> DeliveryPrints { get; set; }
        public virtual DbSet<DeliveryTime> DeliveryTimes { get; set; }
        public virtual DbSet<Delivprint> Delivprints { get; set; }
        public virtual DbSet<Di> Dis { get; set; }
        public virtual DbSet<DisLikeItem> DisLikeItems { get; set; }
        public virtual DbSet<Dislike> Dislikes { get; set; }
        public virtual DbSet<DislikeChange> DislikeChanges { get; set; }
        public virtual DbSet<DislikeType> DislikeTypes { get; set; }
        public virtual DbSet<DprintTran> DprintTrans { get; set; }
        public virtual DbSet<Drivercount> Drivercounts { get; set; }
        public virtual DbSet<EmailSetting> EmailSettings { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EslamTb> EslamTbs { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Expiration> Expirations { get; set; }
        public virtual DbSet<Explan> Explans { get; set; }
        public virtual DbSet<Explan2> Explan2s { get; set; }
        public virtual DbSet<GetProcessView> GetProcessViews { get; set; }
        public virtual DbSet<InContact> InContacts { get; set; }
        public virtual DbSet<Ingcnt> Ingcnts { get; set; }
        public virtual DbSet<Ingrc> Ingrcs { get; set; }
        public virtual DbSet<Ingrdall> Ingrdalls { get; set; }
        public virtual DbSet<Ingrerr> Ingrerrs { get; set; }
        public virtual DbSet<Ingrfr> Ingrfrs { get; set; }
        public virtual DbSet<InvDetail> InvDetails { get; set; }
        public virtual DbSet<InvHdr> InvHdrs { get; set; }
        public virtual DbSet<Invent> Invents { get; set; }
        public virtual DbSet<Invoicepre> Invoicepres { get; set; }
        public virtual DbSet<Invt> Invts { get; set; }
        public virtual DbSet<Invtallb> Invtallbs { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<ItemsBrch> ItemsBrches { get; set; }
        public virtual DbSet<KitArea1> KitArea1s { get; set; }
        public virtual DbSet<Kitch> Kitches { get; set; }
        public virtual DbSet<Kitch2> Kitch2s { get; set; }
        public virtual DbSet<Kitch3> Kitch3s { get; set; }
        public virtual DbSet<Kitchall> Kitchalls { get; set; }
        public virtual DbSet<Kitchall2> Kitchall2s { get; set; }
        public virtual DbSet<Kitchold> Kitcholds { get; set; }
        public virtual DbSet<Kitcold> Kitcolds { get; set; }
        public virtual DbSet<Kitcre> Kitcres { get; set; }
        public virtual DbSet<Kitday2> Kitday2s { get; set; }
        public virtual DbSet<Kitday3> Kitday3s { get; set; }
        public virtual DbSet<Ledger> Ledgers { get; set; }
        public virtual DbSet<Ledgere> Ledgeres { get; set; }
        public virtual DbSet<LikeItem> LikeItems { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MailMergeVariable> MailMergeVariables { get; set; }
        public virtual DbSet<MaxPlan> MaxPlans { get; set; }
        public virtual DbSet<MaxPlanNotAlerg> MaxPlanNotAlergs { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<MealDay> MealDays { get; set; }
        public virtual DbSet<MealDetail> MealDetails { get; set; }
        public virtual DbSet<MealType> MealTypes { get; set; }
        public virtual DbSet<MealsDetail> MealsDetails { get; set; }
        public virtual DbSet<MealsDetail2> MealsDetail2s { get; set; }
        public virtual DbSet<MealsDetail4> MealsDetail4s { get; set; }
        public virtual DbSet<Mealsalescount> Mealsalescounts { get; set; }
        public virtual DbSet<MessKot> MessKots { get; set; }
        public virtual DbSet<MessKot222> MessKot222s { get; set; }
        public virtual DbSet<MessKotch> MessKotches { get; set; }
        public virtual DbSet<Messlog> Messlogs { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<MyPrice> MyPrices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Paytre> Paytres { get; set; }
        public virtual DbSet<Pickupsh> Pickupshes { get; set; }
        public virtual DbSet<Pitemlist> Pitemlists { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<Planpr> Planprs { get; set; }
        public virtual DbSet<Pledger> Pledgers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product1> Products1 { get; set; }
        public virtual DbSet<Product2> Product2s { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductTransaction> ProductTransactions { get; set; }
        public virtual DbSet<ProductTransactionDetail> ProductTransactionDetails { get; set; }
        public virtual DbSet<Rd1> Rd1s { get; set; }
        public virtual DbSet<Rd2> Rd2s { get; set; }
        public virtual DbSet<Rd3> Rd3s { get; set; }
        public virtual DbSet<Rd4> Rd4s { get; set; }
        public virtual DbSet<Rd5> Rd5s { get; set; }
        public virtual DbSet<Rd6> Rd6s { get; set; }
        public virtual DbSet<Rd7> Rd7s { get; set; }
        public virtual DbSet<Rd8> Rd8s { get; set; }
        public virtual DbSet<Rd9> Rd9s { get; set; }
        public virtual DbSet<RefundDetail> RefundDetails { get; set; }
        public virtual DbSet<RefundProductDetail> RefundProductDetails { get; set; }
        public virtual DbSet<RmessKot> RmessKots { get; set; }
        public virtual DbSet<SalesMan> SalesMen { get; set; }
        public virtual DbSet<Sheet5XlnmFilterDatabase> Sheet5XlnmFilterDatabases { get; set; }
        public virtual DbSet<Sponser> Sponsers { get; set; }
        public virtual DbSet<Sslog> Sslogs { get; set; }
        public virtual DbSet<Subblier> Subbliers { get; set; }
        public virtual DbSet<Subduo> Subduos { get; set; }
        public virtual DbSet<Subinv> Subinvs { get; set; }
        public virtual DbSet<SubinvR> SubinvRs { get; set; }
        public virtual DbSet<SubinvRep> SubinvReps { get; set; }
        public virtual DbSet<Subreport> Subreports { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<SubscriptionDetail> SubscriptionDetails { get; set; }
        public virtual DbSet<SubscriptionType> SubscriptionTypes { get; set; }
        public virtual DbSet<Suppli> Supplis { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<T1> T1s { get; set; }
        public virtual DbSet<T10> T10s { get; set; }
        public virtual DbSet<T2> T2s { get; set; }
        public virtual DbSet<T3> T3s { get; set; }
        public virtual DbSet<T4> T4s { get; set; }
        public virtual DbSet<T5> T5s { get; set; }
        public virtual DbSet<T6> T6s { get; set; }
        public virtual DbSet<T7> T7s { get; set; }
        public virtual DbSet<T8> T8s { get; set; }
        public virtual DbSet<TempMealsDetail> TempMealsDetails { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<Tryy> Tryys { get; set; }
        public virtual DbSet<Tw1> Tw1s { get; set; }
        public virtual DbSet<Tw10> Tw10s { get; set; }
        public virtual DbSet<Tw11> Tw11s { get; set; }
        public virtual DbSet<Tw12> Tw12s { get; set; }
        public virtual DbSet<Tw13> Tw13s { get; set; }
        public virtual DbSet<Tw14> Tw14s { get; set; }
        public virtual DbSet<Tw2> Tw2s { get; set; }
        public virtual DbSet<Tw3> Tw3s { get; set; }
        public virtual DbSet<Tw4> Tw4s { get; set; }
        public virtual DbSet<Tw5> Tw5s { get; set; }
        public virtual DbSet<Tw6> Tw6s { get; set; }
        public virtual DbSet<Tw7> Tw7s { get; set; }
        public virtual DbSet<Tw8> Tw8s { get; set; }
        public virtual DbSet<Tw9> Tw9s { get; set; }
        public virtual DbSet<Udday> Uddays { get; set; }
        public virtual DbSet<UnitType> UnitTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WeeklySalesSupscriptionReport> WeeklySalesSupscriptionReports { get; set; }

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=KOT");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Allsave>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ALLSAVE");

                entity.Property(e => e.Cidre).HasColumnName("cidre");

                entity.Property(e => e.Custaddressre).HasColumnName("custaddressre");

                entity.Property(e => e.Custcity).HasColumnName("custcity");

                entity.Property(e => e.Custn).HasColumnName("custn");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Datere).HasColumnName("datere");

                entity.Property(e => e.Delivnre).HasColumnName("delivnre");

                entity.Property(e => e.Meal1).HasColumnName("meal1");

                entity.Property(e => e.Meal2).HasColumnName("meal2");

                entity.Property(e => e.Meal3).HasColumnName("meal3");

                entity.Property(e => e.Meal4).HasColumnName("meal4");

                entity.Property(e => e.Meal5).HasColumnName("meal5");

                entity.Property(e => e.Meal6).HasColumnName("meal6");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Siftre).HasColumnName("siftre");

                entity.Property(e => e.Snacks).HasColumnName("snacks");

                entity.Property(e => e.Snacks2).HasColumnName("snacks2");

                entity.Property(e => e.Snacks3).HasColumnName("snacks3");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.ToTable("AppUser");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("Attendance");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.HasOne(d => d.SalesMan)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.SalesManId)
                    .HasConstraintName("FK_dbo.Attendance_dbo.SalesMan_SalesManId");
            });

            modelBuilder.Entity<AutoDislike>(entity =>
            {
                entity.ToTable("AutoDislike");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Fqty).HasColumnName("FQTY");

                entity.Property(e => e.Rqty).HasColumnName("RQTY");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.AutoDislikes)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AutoDislike_DislikeTypes");
            });

            modelBuilder.Entity<Bagre>(entity =>
            {
                entity.HasKey(e => e.Cidre);

                entity.ToTable("bagre");

                entity.Property(e => e.Cidre)
                    .ValueGeneratedNever()
                    .HasColumnName("cidre");

                entity.Property(e => e.Custaddressre).HasColumnName("custaddressre");

                entity.Property(e => e.Custcity).HasColumnName("custcity");

                entity.Property(e => e.Custn).HasColumnName("custn");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Datere).HasColumnName("datere");

                entity.Property(e => e.Delivnre).HasColumnName("delivnre");

                entity.Property(e => e.Meal1).HasColumnName("meal1");

                entity.Property(e => e.Meal2).HasColumnName("meal2");

                entity.Property(e => e.Meal3).HasColumnName("meal3");

                entity.Property(e => e.Meal4).HasColumnName("meal4");

                entity.Property(e => e.Meal5).HasColumnName("meal5");

                entity.Property(e => e.Meal6).HasColumnName("meal6");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Siftre).HasColumnName("siftre");

                entity.Property(e => e.Snacks).HasColumnName("snacks");

                entity.Property(e => e.Snacks2).HasColumnName("snacks2");

                entity.Property(e => e.Snacks3).HasColumnName("snacks3");
            });

            modelBuilder.Entity<Bagre2>(entity =>
            {
                entity.HasKey(e => e.Cidre);

                entity.ToTable("bagre2");

                entity.Property(e => e.Cidre)
                    .ValueGeneratedNever()
                    .HasColumnName("cidre");

                entity.Property(e => e.Custaddressre).HasColumnName("custaddressre");

                entity.Property(e => e.Custcity).HasColumnName("custcity");

                entity.Property(e => e.Custn).HasColumnName("custn");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Datere).HasColumnName("datere");

                entity.Property(e => e.Delivnre).HasColumnName("delivnre");

                entity.Property(e => e.Meal1).HasColumnName("meal1");

                entity.Property(e => e.Meal2).HasColumnName("meal2");

                entity.Property(e => e.Meal3).HasColumnName("meal3");

                entity.Property(e => e.Meal4).HasColumnName("meal4");

                entity.Property(e => e.Meal5).HasColumnName("meal5");

                entity.Property(e => e.Meal6).HasColumnName("meal6");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Siftre).HasColumnName("siftre");

                entity.Property(e => e.Snacks).HasColumnName("snacks");

                entity.Property(e => e.Snacks2).HasColumnName("snacks2");

                entity.Property(e => e.Snacks3).HasColumnName("snacks3");
            });

            modelBuilder.Entity<BagreD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bagreD");

                entity.Property(e => e.Cidre).HasColumnName("cidre");

                entity.Property(e => e.Custaddressre).HasColumnName("custaddressre");

                entity.Property(e => e.Custcity).HasColumnName("custcity");

                entity.Property(e => e.Custn).HasColumnName("custn");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Datere).HasColumnName("datere");

                entity.Property(e => e.Delivnre).HasColumnName("delivnre");

                entity.Property(e => e.Meal1).HasColumnName("meal1");

                entity.Property(e => e.Meal2).HasColumnName("meal2");

                entity.Property(e => e.Meal3).HasColumnName("meal3");

                entity.Property(e => e.Meal4).HasColumnName("meal4");

                entity.Property(e => e.Meal5).HasColumnName("meal5");

                entity.Property(e => e.Meal6).HasColumnName("meal6");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Siftre).HasColumnName("siftre");

                entity.Property(e => e.Snacks).HasColumnName("snacks");

                entity.Property(e => e.Snacks2).HasColumnName("snacks2");

                entity.Property(e => e.Snacks3).HasColumnName("snacks3");
            });

            modelBuilder.Entity<Bagrech>(entity =>
            {
                entity.HasKey(e => e.Cidre);

                entity.ToTable("bagrech");

                entity.Property(e => e.Cidre)
                    .ValueGeneratedNever()
                    .HasColumnName("cidre");

                entity.Property(e => e.Custaddressre).HasColumnName("custaddressre");

                entity.Property(e => e.Custcity).HasColumnName("custcity");

                entity.Property(e => e.Custn).HasColumnName("custn");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Datere).HasColumnName("datere");

                entity.Property(e => e.Delivnre).HasColumnName("delivnre");

                entity.Property(e => e.Meal1).HasColumnName("meal1");

                entity.Property(e => e.Meal2).HasColumnName("meal2");

                entity.Property(e => e.Meal3).HasColumnName("meal3");

                entity.Property(e => e.Meal4).HasColumnName("meal4");

                entity.Property(e => e.Meal5).HasColumnName("meal5");

                entity.Property(e => e.Meal6).HasColumnName("meal6");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Siftre).HasColumnName("siftre");

                entity.Property(e => e.Snacks).HasColumnName("snacks");

                entity.Property(e => e.Snacks2).HasColumnName("snacks2");

                entity.Property(e => e.Snacks3).HasColumnName("snacks3");
            });

            modelBuilder.Entity<Bagrech2>(entity =>
            {
                entity.HasKey(e => e.Cidre);

                entity.ToTable("bagrech2");

                entity.Property(e => e.Cidre)
                    .ValueGeneratedNever()
                    .HasColumnName("cidre");

                entity.Property(e => e.Custaddressre).HasColumnName("custaddressre");

                entity.Property(e => e.Custcity).HasColumnName("custcity");

                entity.Property(e => e.Custn).HasColumnName("custn");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Datere).HasColumnName("datere");

                entity.Property(e => e.Delivnre).HasColumnName("delivnre");

                entity.Property(e => e.Meal1).HasColumnName("meal1");

                entity.Property(e => e.Meal2).HasColumnName("meal2");

                entity.Property(e => e.Meal3).HasColumnName("meal3");

                entity.Property(e => e.Meal4).HasColumnName("meal4");

                entity.Property(e => e.Meal5).HasColumnName("meal5");

                entity.Property(e => e.Meal6).HasColumnName("meal6");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Siftre).HasColumnName("siftre");

                entity.Property(e => e.Snacks).HasColumnName("snacks");

                entity.Property(e => e.Snacks2).HasColumnName("snacks2");

                entity.Property(e => e.Snacks3).HasColumnName("snacks3");
            });

            modelBuilder.Entity<Bagrer>(entity =>
            {
                entity.HasKey(e => e.Cidre);

                entity.ToTable("BAGRER");

                entity.Property(e => e.Cidre)
                    .ValueGeneratedNever()
                    .HasColumnName("cidre");

                entity.Property(e => e.Custaddressre).HasColumnName("custaddressre");

                entity.Property(e => e.Custcity).HasColumnName("custcity");

                entity.Property(e => e.Custn).HasColumnName("custn");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Datere).HasColumnName("datere");

                entity.Property(e => e.Delivnre).HasColumnName("delivnre");

                entity.Property(e => e.Meal1).HasColumnName("meal1");

                entity.Property(e => e.Meal2).HasColumnName("meal2");

                entity.Property(e => e.Meal3).HasColumnName("meal3");

                entity.Property(e => e.Meal4).HasColumnName("meal4");

                entity.Property(e => e.Meal5).HasColumnName("meal5");

                entity.Property(e => e.Meal6).HasColumnName("meal6");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Siftre).HasColumnName("siftre");

                entity.Property(e => e.Snacks).HasColumnName("snacks");

                entity.Property(e => e.Snacks2).HasColumnName("snacks2");

                entity.Property(e => e.Snacks3).HasColumnName("snacks3");
            });

            modelBuilder.Entity<BillItemDetail>(entity =>
            {
                entity.ToTable("BillItemDetail");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.PosBill)
                    .WithMany(p => p.BillItemDetails)
                    .HasForeignKey(d => d.PosBillId)
                    .HasConstraintName("FK_dbo.BillItemDetail_dbo.BillRecored_PosBillId");

                entity.HasOne(d => d.PosItem)
                    .WithMany(p => p.BillItemDetails)
                    .HasForeignKey(d => d.PosItemId)
                    .HasConstraintName("FK_dbo.BillItemDetail_dbo.Product_PosItemId");
            });

            modelBuilder.Entity<BillRecored>(entity =>
            {
                entity.ToTable("BillRecored");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Delivery).HasColumnName("DELIVERY");

                entity.Property(e => e.Planname).HasColumnName("PLANNAME");

                entity.Property(e => e.Totaldisc).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.BillRecoreds)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.BillRecored_dbo.AppUser_AppUserId");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BrchId);

                entity.Property(e => e.BrchId).HasColumnName("Brch_id");

                entity.Property(e => e.BrchName)
                    .HasMaxLength(50)
                    .HasColumnName("Brch_name");

                entity.Property(e => e.PurVPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Pur_v_price");
            });

            modelBuilder.Entity<Chashir>(entity =>
            {
                entity.ToTable("CHASHIRS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Cashir).HasColumnName("CASHIR");

                entity.Property(e => e.Comm).HasColumnName("COMM");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Clincp>(entity =>
            {
                entity.ToTable("CLINCP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Comm2).HasColumnName("COMM2");

                entity.Property(e => e.Comm3).HasColumnName("COMM3");

                entity.Property(e => e.Disc).HasColumnName("DISC");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Servn)
                    .HasMaxLength(50)
                    .HasColumnName("SERVN");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<Clncserv>(entity =>
            {
                entity.ToTable("CLNCSERV");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cashir).HasColumnName("CASHIR");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Comm2).HasColumnName("COMM2");

                entity.Property(e => e.Comm3).HasColumnName("COMM3");

                entity.Property(e => e.Comm4).HasColumnName("COMM4");

                entity.Property(e => e.Custemai).HasColumnName("CUSTEMAI");

                entity.Property(e => e.Custn).HasColumnName("CUSTN");

                entity.Property(e => e.Custph).HasColumnName("CUSTPH");

                entity.Property(e => e.Dateinv).HasColumnName("DATEINV");

                entity.Property(e => e.Disc).HasColumnName("DISC");

                entity.Property(e => e.Invn).HasColumnName("INVN");

                entity.Property(e => e.Pricwov)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PRICWOV");

                entity.Property(e => e.Recomn).HasColumnName("RECOMN");

                entity.Property(e => e.Servn).HasColumnName("SERVN");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<Custinvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("custinvoice");

                entity.Property(e => e.Addedsnacks).HasColumnName("addedsnacks");

                entity.Property(e => e.Custaddress).HasColumnName("custaddress");

                entity.Property(e => e.Custbranch).HasColumnName("custbranch");

                entity.Property(e => e.Custemail).HasColumnName("custemail");

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Custmobile).HasColumnName("custmobile");

                entity.Property(e => e.Custname).HasColumnName("custname");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Custplanename).HasColumnName("custplanename");

                entity.Property(e => e.Datecreate).HasColumnName("datecreate");

                entity.Property(e => e.Discountpercnt).HasColumnName("discountpercnt");

                entity.Property(e => e.Discvalue).HasColumnName("discvalue");

                entity.Property(e => e.Noofdays).HasColumnName("noofdays");

                entity.Property(e => e.Payby).HasColumnName("payby");

                entity.Property(e => e.Planemprice).HasColumnName("planemprice");

                entity.Property(e => e.Planetype).HasColumnName("planetype");

                entity.Property(e => e.Priceend).HasColumnName("priceend");

                entity.Property(e => e.Pricewithoutdisc).HasColumnName("pricewithoutdisc");

                entity.Property(e => e.Remainingmeals).HasColumnName("remainingmeals");

                entity.Property(e => e.Startday).HasColumnName("startday");

                entity.Property(e => e.Transno).HasColumnName("transno");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Comment13).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CustomerDob)
                    .HasColumnType("datetime")
                    .HasColumnName("CustomerDOB");

                entity.Property(e => e.CustomerStartDay).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliveryCustomer).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryTimeId)
                    .HasColumnName("DeliveryTimeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.NoOfDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.PickUpCustomer).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.SubscriptionTypeId)
                    .HasColumnName("SubscriptionTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CustomerLocationMainNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerLocationMain)
                    .HasConstraintName("FK_dbo.Customers_dbo.Location_CustomerLocationMain");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.Customers_dbo.Employees_EmployeeID");
            });

            modelBuilder.Entity<CustomerPlan>(entity =>
            {
                entity.Property(e => e.CustomerPlanId).HasColumnName("CustomerPlanID");

                entity.Property(e => e.Branchn).HasColumnName("branchn");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Comm2).HasColumnName("COMM2");

                entity.Property(e => e.Comm3).HasColumnName("COMM3");

                entity.Property(e => e.Comm4).HasColumnName("COMM4");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Custaddress).HasColumnName("custaddress");

                entity.Property(e => e.Custmobile).HasColumnName("custmobile");

                entity.Property(e => e.Custname).HasColumnName("custname");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Custplan).HasColumnName("custplan");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.Delivercust).HasColumnName("delivercust");

                entity.Property(e => e.Endd).HasColumnType("datetime");

                entity.Property(e => e.MealDayCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.MealTypeId).HasColumnName("MealTypeID");

                entity.Property(e => e.Mealtypename).HasColumnName("mealtypename");

                entity.Property(e => e.Pickbr).HasColumnName("PICKBR");

                entity.Property(e => e.Picup).HasColumnName("picup");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ristricend).HasColumnType("datetime");

                entity.Property(e => e.Ristricstartd).HasColumnType("datetime");

                entity.Property(e => e.Startdatek).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.Taken).HasColumnName("TAKEN");

                entity.Property(e => e.Untillcall).HasColumnName("UNTILLCALL");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPlans)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerPlans_Customers");
            });

            modelBuilder.Entity<CustomerPlansSh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomerPlansSH");

                entity.Property(e => e.Branchn).HasColumnName("branchn");

                entity.Property(e => e.Custaddress).HasColumnName("custaddress");

                entity.Property(e => e.Custmobile).HasColumnName("custmobile");

                entity.Property(e => e.Custname).HasColumnName("custname");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerPlanId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CustomerPlanID");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Custplan).HasColumnName("custplan");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.Delivercust).HasColumnName("delivercust");

                entity.Property(e => e.IsDeliverd).IsRequired();

                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.MealTypeId).HasColumnName("MealTypeID");

                entity.Property(e => e.Mealtypename).HasColumnName("mealtypename");

                entity.Property(e => e.Picup).HasColumnName("picup");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.Taken).HasColumnName("TAKEN");
            });

            modelBuilder.Entity<CustomersExpiration>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CustomersExpiration");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Expiration).HasColumnType("datetime");

                entity.Property(e => e.Last)
                    .HasColumnType("datetime")
                    .HasColumnName("last");
            });

            modelBuilder.Entity<CustomersLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CustomersLocations");

                entity.Property(e => e.Branchn).HasColumnName("branchn");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");
            });

            modelBuilder.Entity<D>(entity =>
            {
                entity.ToTable("D");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<D1>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("D1");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<D2>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("D2");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<D3>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("D3");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<D4>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("D4");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<D5>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("D5");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<D6>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("D6");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<D7>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("D7");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<D8>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("D8");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<D9>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("D9");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CID");

                entity.Property(e => e.Ca).HasColumnName("CA");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<DailyDeliveryOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DAILY_DELIVERY_ORDER");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Cname).HasColumnName("CName");

                entity.Property(e => e.Dt).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DAILY_UPDATES");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Dstart)
                    .HasColumnType("datetime")
                    .HasColumnName("DSTART");

                entity.Property(e => e.Jobn).HasColumnName("JOBN");
            });

            modelBuilder.Entity<Dailyreo>(entity =>
            {
                entity.ToTable("DAILYREO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnName("DETAILS");

                entity.Property(e => e.Driver).HasColumnName("DRIVER");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(10)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.Note2).HasColumnName("NOTE2");

                entity.Property(e => e.Note3).HasColumnName("NOTE3");

                entity.Property(e => e.Note4).HasColumnName("NOTE4");

                entity.Property(e => e.Note5).HasColumnName("NOTE5");

                entity.Property(e => e.Note6).HasColumnName("NOTE6");

                entity.Property(e => e.Payment).HasColumnName("PAYMENT");

                entity.Property(e => e.Permissioncode).HasColumnName("PERMISSIONCODE");

                entity.Property(e => e.Phone).HasColumnName("PHONE");

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.Request)
                    .IsRequired()
                    .HasColumnName("REQUEST");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.HasKey(e => e.Dayidd);

                entity.Property(e => e.Dayidd).ValueGeneratedNever();

                entity.Property(e => e.DayName).HasMaxLength(50);
            });

            modelBuilder.Entity<DeliveryPrint>(entity =>
            {
                entity.ToTable("delivery_print");

                entity.Property(e => e.Dateofpr).HasColumnName("dateofpr");

                entity.Property(e => e.Dilivname).HasColumnName("dilivname");

                entity.Property(e => e.Shift).HasColumnName("shift");
            });

            modelBuilder.Entity<DeliveryTime>(entity =>
            {
                entity.Property(e => e.DeliveryTimeId).HasColumnName("DeliveryTimeID");
            });

            modelBuilder.Entity<Delivprint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("delivprint");

                entity.Property(e => e.Dateofpr).HasColumnName("dateofpr");

                entity.Property(e => e.Dilivname).HasColumnName("dilivname");

                entity.Property(e => e.Shift).HasColumnName("shift");
            });

            modelBuilder.Entity<Di>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DIS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mealno)
                    .HasMaxLength(255)
                    .HasColumnName("MEALNO");

                entity.Property(e => e.Mealtypename).HasMaxLength(255);

                entity.Property(e => e.Newmid).HasColumnName("newmid");

                entity.Property(e => e.Nobeans).HasColumnName("NOBEANS");

                entity.Property(e => e.Noegg).HasColumnName("NOEGG");

                entity.Property(e => e.Nofish).HasColumnName("NOFISH");

                entity.Property(e => e.Noshrimp).HasColumnName("NOSHRIMP");

                entity.Property(e => e.Nosteak).HasColumnName("NOSTEAK");

                entity.Property(e => e.Oldmid).HasColumnName("oldmid");
            });

            modelBuilder.Entity<DisLikeItem>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Dislike>(entity =>
            {
                entity.ToTable("dislike");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Calories).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Carb).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Fats).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mealna).HasColumnName("MEALNA");

                entity.Property(e => e.Newmid).HasColumnName("newmid");

                entity.Property(e => e.Nobeans).HasColumnName("NOBEANS");

                entity.Property(e => e.Noegg).HasColumnName("NOEGG");

                entity.Property(e => e.Nofish).HasColumnName("NOFISH");

                entity.Property(e => e.Noshrimp).HasColumnName("NOSHRIMP");

                entity.Property(e => e.Nosteak).HasColumnName("NOSTEAK");

                entity.Property(e => e.Oldmid).HasColumnName("oldmid");

                entity.Property(e => e.Protiens).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DislikeChange>(entity =>
            {
                entity.ToTable("DislikeChange");

                entity.Property(e => e.Dqtty).HasColumnName("DQTTY");

                entity.Property(e => e.Lqtty).HasColumnName("LQTTY");

                entity.HasOne(d => d.DisLike)
                    .WithMany(p => p.DislikeChanges)
                    .HasForeignKey(d => d.DisLikeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DislikeChange_DislikeItems1");

                entity.HasOne(d => d.DislikeTypeNavigation)
                    .WithMany(p => p.DislikeChanges)
                    .HasForeignKey(d => d.DislikeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DislikeChange_DislikeTypes");

                entity.HasOne(d => d.Like)
                    .WithMany(p => p.DislikeChanges)
                    .HasForeignKey(d => d.LikeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DislikeChange_LikeItems");
            });

            modelBuilder.Entity<DislikeType>(entity =>
            {
                entity.Property(e => e.AutoDislikeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DprintTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dprint_trans");

                entity.Property(e => e.Dateofpr).HasColumnName("dateofpr");

                entity.Property(e => e.Dilivname).HasColumnName("dilivname");

                entity.Property(e => e.Shift).HasColumnName("shift");
            });

            modelBuilder.Entity<Drivercount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("drivercount");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Custc)
                    .HasMaxLength(50)
                    .HasColumnName("custc");

                entity.Property(e => e.Dater).HasColumnName("dater");

                entity.Property(e => e.Drivern)
                    .HasMaxLength(50)
                    .HasColumnName("drivern");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<EmailSetting>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Ssl).HasColumnName("SSL");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.EmailTemplates)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_dbo.EmailTemplates_dbo.Templates_TemplateId");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EslamTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Eslam_TB");

                entity.Property(e => e.BranchPhone).HasMaxLength(50);

                entity.Property(e => e.Branchname).HasMaxLength(50);

                entity.Property(e => e.Sid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.ToTable("Expense");

                entity.Property(e => e.ExpenseTime).HasColumnType("datetime");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.Expense_dbo.AppUser_AppUserId");
            });

            modelBuilder.Entity<Expiration>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Expiration");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.LastDay).HasColumnType("date");

                entity.Property(e => e.LastInvoice)
                    .HasColumnType("date")
                    .HasColumnName("last_Invoice");
            });

            modelBuilder.Entity<Explan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXPLAN");

                entity.Property(e => e.Expln).HasColumnName("EXPLN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<Explan2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXPLAN2");

                entity.Property(e => e.Expln).HasColumnName("EXPLN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<GetProcessView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetProcessView");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Cid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cid");

                entity.Property(e => e.Mealname).HasColumnName("mealname");

                entity.Property(e => e.Mealunit).HasColumnName("mealunit");

                entity.Property(e => e.Prosses1).HasMaxLength(50);

                entity.Property(e => e.Prosses2).HasMaxLength(50);

                entity.Property(e => e.Prosses3).HasMaxLength(50);
            });

            modelBuilder.Entity<InContact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Ingcnt>(entity =>
            {
                entity.ToTable("ingcnt");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ext)
                    .HasMaxLength(255)
                    .HasColumnName("EXT");

                entity.Property(e => e.Ext1)
                    .HasMaxLength(255)
                    .HasColumnName("EXT1");

                entity.Property(e => e.Ext2)
                    .HasMaxLength(255)
                    .HasColumnName("EXT2");

                entity.Property(e => e.Ext3)
                    .HasMaxLength(255)
                    .HasColumnName("EXT3");

                entity.Property(e => e.Ext4)
                    .HasMaxLength(255)
                    .HasColumnName("EXT4");

                entity.Property(e => e.Ext5)
                    .HasMaxLength(255)
                    .HasColumnName("EXT5");

                entity.Property(e => e.Ext6)
                    .HasMaxLength(255)
                    .HasColumnName("EXT6");

                entity.Property(e => e.Ext7)
                    .HasMaxLength(255)
                    .HasColumnName("EXT7");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.ItemName2).HasColumnName("item_name2");

                entity.Property(e => e.ItemSubId).HasColumnName("item_sub_id");

                entity.Property(e => e.PurPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.HasOne(d => d.ItemSub)
                    .WithMany(p => p.Ingcnts)
                    .HasForeignKey(d => d.ItemSubId)
                    .HasConstraintName("FK_ingcnt_Subblier");
            });

            modelBuilder.Entity<Ingrc>(entity =>
            {
                entity.ToTable("ingrc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amountins).HasColumnName("AMOUNTINS");

                entity.Property(e => e.Fgminam).HasColumnName("FGMINAM");

                entity.Property(e => e.Finamnt).HasColumnName("FINAMNT");

                entity.Property(e => e.Gmpc).HasColumnName("GMPC");

                entity.Property(e => e.Gmpwvat).HasColumnName("GMPWVAT");

                entity.Property(e => e.Gmunit).HasColumnName("GMUNIT");

                entity.Property(e => e.Ingname)
                    .HasMaxLength(255)
                    .HasColumnName("INGNAME");

                entity.Property(e => e.Insper).HasColumnName("INSPER");

                entity.Property(e => e.Instore)
                    .HasMaxLength(255)
                    .HasColumnName("INSTORE");

                entity.Property(e => e.Insunit)
                    .HasMaxLength(255)
                    .HasColumnName("INSUNIT");

                entity.Property(e => e.Kpwvat).HasColumnName("KPWVAT");

                entity.Property(e => e.Munit)
                    .HasMaxLength(255)
                    .HasColumnName("MUNIT");

                entity.Property(e => e.Nameprch)
                    .HasMaxLength(255)
                    .HasColumnName("NAMEPRCH");

                entity.Property(e => e.Norp)
                    .HasMaxLength(255)
                    .HasColumnName("NORP");

                entity.Property(e => e.Recip).HasColumnName("RECIP");

                entity.Property(e => e.Runit)
                    .HasMaxLength(255)
                    .HasColumnName("RUNIT");

                entity.Property(e => e.Smunit)
                    .HasMaxLength(255)
                    .HasColumnName("SMUNIT");

                entity.Property(e => e.Suppn)
                    .HasMaxLength(255)
                    .HasColumnName("SUPPN");

                entity.Property(e => e.Tpricewovat).HasColumnName("TPRICEWOVAT");
            });

            modelBuilder.Entity<Ingrdall>(entity =>
            {
                entity.ToTable("INGRDALL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Comm2).HasColumnName("COMM2");

                entity.Property(e => e.Comm3).HasColumnName("COMM3");

                entity.Property(e => e.Comm4).HasColumnName("COMM4");

                entity.Property(e => e.Gm1).HasColumnName("GM1");

                entity.Property(e => e.Gm10).HasColumnName("GM10");

                entity.Property(e => e.Gm11).HasColumnName("GM11");

                entity.Property(e => e.Gm12).HasColumnName("GM12");

                entity.Property(e => e.Gm13).HasColumnName("GM13");

                entity.Property(e => e.Gm14).HasColumnName("GM14");

                entity.Property(e => e.Gm15).HasColumnName("GM15");

                entity.Property(e => e.Gm16).HasColumnName("GM16");

                entity.Property(e => e.Gm17).HasColumnName("GM17");

                entity.Property(e => e.Gm18).HasColumnName("GM18");

                entity.Property(e => e.Gm19).HasColumnName("GM19");

                entity.Property(e => e.Gm2).HasColumnName("GM2");

                entity.Property(e => e.Gm20).HasColumnName("GM20");

                entity.Property(e => e.Gm21).HasColumnName("GM21");

                entity.Property(e => e.Gm22).HasColumnName("GM22");

                entity.Property(e => e.Gm3).HasColumnName("GM3");

                entity.Property(e => e.Gm4).HasColumnName("GM4");

                entity.Property(e => e.Gm5).HasColumnName("GM5");

                entity.Property(e => e.Gm6).HasColumnName("GM6");

                entity.Property(e => e.Gm7).HasColumnName("GM7");

                entity.Property(e => e.Gm8).HasColumnName("GM8");

                entity.Property(e => e.Gm9).HasColumnName("GM9");

                entity.Property(e => e.Ing1)
                    .HasMaxLength(255)
                    .HasColumnName("ING1");

                entity.Property(e => e.Ing10)
                    .HasMaxLength(255)
                    .HasColumnName("ING10");

                entity.Property(e => e.Ing11)
                    .HasMaxLength(255)
                    .HasColumnName("ING11");

                entity.Property(e => e.Ing12)
                    .HasMaxLength(255)
                    .HasColumnName("ING12");

                entity.Property(e => e.Ing13)
                    .HasMaxLength(255)
                    .HasColumnName("ING13");

                entity.Property(e => e.Ing14)
                    .HasMaxLength(255)
                    .HasColumnName("ING14");

                entity.Property(e => e.Ing15)
                    .HasMaxLength(255)
                    .HasColumnName("ING15");

                entity.Property(e => e.Ing16)
                    .HasMaxLength(255)
                    .HasColumnName("ING16");

                entity.Property(e => e.Ing17)
                    .HasMaxLength(255)
                    .HasColumnName("ING17");

                entity.Property(e => e.Ing18)
                    .HasMaxLength(255)
                    .HasColumnName("ING18");

                entity.Property(e => e.Ing19)
                    .HasMaxLength(255)
                    .HasColumnName("ING19");

                entity.Property(e => e.Ing2)
                    .HasMaxLength(255)
                    .HasColumnName("ING2");

                entity.Property(e => e.Ing20)
                    .HasMaxLength(255)
                    .HasColumnName("ING20");

                entity.Property(e => e.Ing21)
                    .HasMaxLength(255)
                    .HasColumnName("ING21");

                entity.Property(e => e.Ing22)
                    .HasMaxLength(255)
                    .HasColumnName("ING22");

                entity.Property(e => e.Ing3)
                    .HasMaxLength(255)
                    .HasColumnName("ING3");

                entity.Property(e => e.Ing4)
                    .HasMaxLength(255)
                    .HasColumnName("ING4");

                entity.Property(e => e.Ing5)
                    .HasMaxLength(255)
                    .HasColumnName("ING5");

                entity.Property(e => e.Ing6)
                    .HasMaxLength(255)
                    .HasColumnName("ING6");

                entity.Property(e => e.Ing7)
                    .HasMaxLength(255)
                    .HasColumnName("ING7");

                entity.Property(e => e.Ing8)
                    .HasMaxLength(255)
                    .HasColumnName("ING8");

                entity.Property(e => e.Ing9)
                    .HasMaxLength(255)
                    .HasColumnName("ING9");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Toting).HasColumnName("TOTING");

                entity.Property(e => e.Units).HasColumnName("UNITS");
            });

            modelBuilder.Entity<Ingrerr>(entity =>
            {
                entity.ToTable("INGRERR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Itemn).HasColumnName("ITEMN");
            });

            modelBuilder.Entity<Ingrfr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INGRFR");

                entity.Property(e => e.Amountins).HasColumnName("AMOUNTINS");

                entity.Property(e => e.Fgminam).HasColumnName("FGMINAM");

                entity.Property(e => e.Finamnt).HasColumnName("FINAMNT");

                entity.Property(e => e.Gmpc).HasColumnName("GMPC");

                entity.Property(e => e.Gmpwvat).HasColumnName("GMPWVAT");

                entity.Property(e => e.Gmunit).HasColumnName("GMUNIT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ingname)
                    .HasMaxLength(255)
                    .HasColumnName("INGNAME");

                entity.Property(e => e.Insper).HasColumnName("INSPER");

                entity.Property(e => e.Instore)
                    .HasMaxLength(255)
                    .HasColumnName("INSTORE");

                entity.Property(e => e.Insunit)
                    .HasMaxLength(255)
                    .HasColumnName("INSUNIT");

                entity.Property(e => e.Kpwvat).HasColumnName("KPWVAT");

                entity.Property(e => e.Munit)
                    .HasMaxLength(255)
                    .HasColumnName("MUNIT");

                entity.Property(e => e.Nameprch)
                    .HasMaxLength(255)
                    .HasColumnName("NAMEPRCH");

                entity.Property(e => e.Norp)
                    .HasMaxLength(255)
                    .HasColumnName("NORP");

                entity.Property(e => e.Recip).HasColumnName("RECIP");

                entity.Property(e => e.Runit)
                    .HasMaxLength(255)
                    .HasColumnName("RUNIT");

                entity.Property(e => e.Smunit)
                    .HasMaxLength(255)
                    .HasColumnName("SMUNIT");

                entity.Property(e => e.Suppn)
                    .HasMaxLength(255)
                    .HasColumnName("SUPPN");

                entity.Property(e => e.Tpricewovat).HasColumnName("TPRICEWOVAT");
            });

            modelBuilder.Entity<InvDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Inv_detail");

                entity.Property(e => e.DetailId).HasColumnName("detail_id");

                entity.Property(e => e.DetailHdrId).HasColumnName("detail_hdr_id");

                entity.Property(e => e.DetailItemId).HasColumnName("detail_item_id");

                entity.Property(e => e.DetailItemName2)
                    .HasMaxLength(50)
                    .HasColumnName("detail_item_name2");

                entity.Property(e => e.DetailItemPurPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("detail_item_Pur_price");

                entity.Property(e => e.DetailItemQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("detail_item_qty");

                entity.Property(e => e.DetailItemTlLine)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("detail_item_tl_line");

                entity.HasOne(d => d.DetailHdr)
                    .WithMany(p => p.InvDetails)
                    .HasForeignKey(d => d.DetailHdrId)
                    .HasConstraintName("FK_Inv_detail_Inv_hdr");

                entity.HasOne(d => d.DetailItem)
                    .WithMany(p => p.InvDetails)
                    .HasForeignKey(d => d.DetailItemId)
                    .HasConstraintName("FK_Inv_detail_ingcnt");
            });

            modelBuilder.Entity<InvHdr>(entity =>
            {
                entity.HasKey(e => e.HdrId);

                entity.ToTable("Inv_hdr");

                entity.Property(e => e.HdrId).HasColumnName("hdr_id");

                entity.Property(e => e.HdrBrch).HasColumnName("hdr_brch");

                entity.Property(e => e.HdrCode)
                    .HasMaxLength(50)
                    .HasColumnName("hdr_code");

                entity.Property(e => e.HdrDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("hdr_DateTime");

                entity.Property(e => e.HdrDisc).HasColumnName("hdr_disc");

                entity.Property(e => e.HdrNet)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("hdr_net");

                entity.Property(e => e.HdrSubId).HasColumnName("hdr_sub_id");

                entity.Property(e => e.HdrTax).HasColumnName("hdr_tax");

                entity.Property(e => e.HdrTaxVal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("hdr_tax_val");

                entity.Property(e => e.HdrTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("hdr_total");

                entity.Property(e => e.HdrType).HasColumnName("hdr_type");

                entity.Property(e => e.PayType)
                    .HasColumnName("pay_type")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.HdrBrchNavigation)
                    .WithMany(p => p.InvHdrs)
                    .HasForeignKey(d => d.HdrBrch)
                    .HasConstraintName("FK_Inv_hdr_Branches");

                entity.HasOne(d => d.HdrSub)
                    .WithMany(p => p.InvHdrs)
                    .HasForeignKey(d => d.HdrSubId)
                    .HasConstraintName("FK_Inv_hdr_Subblier");
            });

            modelBuilder.Entity<Invent>(entity =>
            {
                entity.ToTable("INVENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brnch).HasColumnName("brnch");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Comm2).HasColumnName("COMM2");

                entity.Property(e => e.Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("dat");

                entity.Property(e => e.Gm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("gm");

                entity.Property(e => e.Ing).HasColumnName("ing");
            });

            modelBuilder.Entity<Invoicepre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("invoicepre");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Invt>(entity =>
            {
                entity.ToTable("INVT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brnch).HasColumnName("brnch");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Comm2)
                    .HasColumnType("datetime")
                    .HasColumnName("COMM2");

                entity.Property(e => e.Comm3).HasColumnName("COMM3");

                entity.Property(e => e.Comm4).HasColumnName("COMM4");

                entity.Property(e => e.Comm5).HasColumnName("COMM5");

                entity.Property(e => e.Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("dat");

                entity.Property(e => e.Gm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("gm");

                entity.Property(e => e.Ing).HasColumnName("ing");
            });

            modelBuilder.Entity<Invtallb>(entity =>
            {
                entity.ToTable("INVTALLB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brnch).HasColumnName("brnch");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Comm2)
                    .HasColumnType("datetime")
                    .HasColumnName("COMM2");

                entity.Property(e => e.Comm3).HasColumnName("COMM3");

                entity.Property(e => e.Comm4).HasColumnName("COMM4");

                entity.Property(e => e.Comm5).HasColumnName("COMM5");

                entity.Property(e => e.Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("dat");

                entity.Property(e => e.Gm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("gm");

                entity.Property(e => e.Ing).HasColumnName("ing");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("ITEMS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Invn).HasColumnName("INVN");

                entity.Property(e => e.Item1)
                    .HasColumnName("ITEM1")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item11)
                    .HasColumnName("ITEM11")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item110)
                    .HasColumnName("ITEM110")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item12)
                    .HasColumnName("ITEM12")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item13)
                    .HasColumnName("ITEM13")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item14)
                    .HasColumnName("ITEM14")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item15)
                    .HasColumnName("ITEM15")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item16)
                    .HasColumnName("ITEM16")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item17)
                    .HasColumnName("ITEM17")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item18)
                    .HasColumnName("ITEM18")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item19)
                    .HasColumnName("ITEM19")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item2)
                    .HasColumnName("ITEM2")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item21)
                    .HasColumnName("ITEM21")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item22)
                    .HasColumnName("ITEM22")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item23)
                    .HasColumnName("ITEM23")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item24)
                    .HasColumnName("ITEM24")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item25)
                    .HasColumnName("ITEM25")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item26)
                    .HasColumnName("ITEM26")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item27)
                    .HasColumnName("ITEM27")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item28)
                    .HasColumnName("ITEM28")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item29)
                    .HasColumnName("ITEM29")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item3)
                    .HasColumnName("ITEM3")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item31)
                    .HasColumnName("ITEM31")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item32)
                    .HasColumnName("ITEM32")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item33)
                    .HasColumnName("ITEM33")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item34)
                    .HasColumnName("ITEM34")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item35)
                    .HasColumnName("ITEM35")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item36)
                    .HasColumnName("ITEM36")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item37)
                    .HasColumnName("ITEM37")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item38)
                    .HasColumnName("ITEM38")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Item39)
                    .HasColumnName("ITEM39")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Sendern).HasColumnName("SENDERN");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.ToTable("ItemType");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            });

            modelBuilder.Entity<ItemsBrch>(entity =>
            {
                entity.HasKey(e => e.ItemBrchId);

                entity.ToTable("Items_Brch");

                entity.Property(e => e.ItemBrchId).HasColumnName("Item_Brch_id");

                entity.Property(e => e.BrchId).HasColumnName("Brch_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemSalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("item_sale_price");

                entity.HasOne(d => d.Brch)
                    .WithMany(p => p.ItemsBrches)
                    .HasForeignKey(d => d.BrchId)
                    .HasConstraintName("FK_Items_Brch_Branches");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemsBrches)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Items_Brch_ingcnt");
            });

            modelBuilder.Entity<KitArea1>(entity =>
            {
                entity.ToTable("KitArea1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Kitch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kitch");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Dayid).HasColumnName("dayid");

                entity.Property(e => e.Mealid).HasColumnName("mealid");

                entity.Property(e => e.Mealname).HasColumnName("mealname");

                entity.Property(e => e.Mealunit).HasColumnName("mealunit");

                entity.Property(e => e.Subscid).HasColumnName("subscid");
            });

            modelBuilder.Entity<Kitch2>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("kitch2");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Mealname).HasColumnName("mealname");

                entity.Property(e => e.Mealunit).HasColumnName("mealunit");
            });

            modelBuilder.Entity<Kitch3>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("KITCH3");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Mealname).HasColumnName("mealname");

                entity.Property(e => e.Mealunit).HasColumnName("mealunit");
            });

            modelBuilder.Entity<Kitchall>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("KITCHALL");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Mealname)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("mealname");

                entity.Property(e => e.Mealunit).HasColumnName("mealunit");
            });

            modelBuilder.Entity<Kitchall2>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("KITCHALL2");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Mealname)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("mealname");

                entity.Property(e => e.Mealunit).HasColumnName("mealunit");
            });

            modelBuilder.Entity<Kitchold>(entity =>
            {
                entity.HasKey(e => e.Mealid);

                entity.ToTable("kitchold");

                entity.Property(e => e.Mealid)
                    .ValueGeneratedNever()
                    .HasColumnName("mealid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Dayid).HasColumnName("dayid");

                entity.Property(e => e.Mealname).HasColumnName("mealname");

                entity.Property(e => e.Mealunit).HasColumnName("mealunit");

                entity.Property(e => e.Subscid).HasColumnName("subscid");
            });

            modelBuilder.Entity<Kitcold>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kitcold");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Dayid).HasColumnName("dayid");

                entity.Property(e => e.Mealid).HasColumnName("mealid");

                entity.Property(e => e.Mealname).HasColumnName("mealname");

                entity.Property(e => e.Mealunit).HasColumnName("mealunit");

                entity.Property(e => e.Subscid).HasColumnName("subscid");
            });

            modelBuilder.Entity<Kitcre>(entity =>
            {
                entity.HasKey(e => e.Mealid);

                entity.ToTable("kitcre");

                entity.Property(e => e.Mealid)
                    .ValueGeneratedNever()
                    .HasColumnName("mealid");

                entity.Property(e => e.Countmeal).HasColumnName("countmeal");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Mealname).HasColumnName("mealname");
            });

            modelBuilder.Entity<Kitday2>(entity =>
            {
                entity.ToTable("kitday2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comm)
                    .HasMaxLength(50)
                    .HasColumnName("comm");

                entity.Property(e => e.Comm2)
                    .HasMaxLength(50)
                    .HasColumnName("comm2");

                entity.Property(e => e.Datek)
                    .HasColumnType("datetime")
                    .HasColumnName("datek");

                entity.Property(e => e.Dateke)
                    .HasColumnType("datetime")
                    .HasColumnName("dateke");

                entity.Property(e => e.Daycn)
                    .HasMaxLength(50)
                    .HasColumnName("daycn");

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .HasColumnName("dname");
            });

            modelBuilder.Entity<Kitday3>(entity =>
            {
                entity.ToTable("kitday3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comm)
                    .HasMaxLength(50)
                    .HasColumnName("comm");

                entity.Property(e => e.Comm2)
                    .HasMaxLength(50)
                    .HasColumnName("comm2");

                entity.Property(e => e.Datek)
                    .HasColumnType("datetime")
                    .HasColumnName("datek");

                entity.Property(e => e.Dateke)
                    .HasColumnType("datetime")
                    .HasColumnName("dateke");

                entity.Property(e => e.Daycn)
                    .HasMaxLength(50)
                    .HasColumnName("daycn");

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .HasColumnName("dname");
            });

            modelBuilder.Entity<Ledger>(entity =>
            {
                entity.ToTable("LEDGER");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.Comment2).HasColumnName("COMMENT2");

                entity.Property(e => e.Comment3).HasColumnName("COMMENT3");

                entity.Property(e => e.Dend)
                    .HasColumnType("datetime")
                    .HasColumnName("DEND");

                entity.Property(e => e.Dstart)
                    .HasColumnType("datetime")
                    .HasColumnName("DSTART");

                entity.Property(e => e.Jobn).HasColumnName("JOBN");
            });

            modelBuilder.Entity<Ledgere>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LEDGERe");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.Comment2).HasColumnName("COMMENT2");

                entity.Property(e => e.Comment3).HasColumnName("COMMENT3");

                entity.Property(e => e.Dafrom).HasColumnName("DAFROM");

                entity.Property(e => e.Dato).HasColumnName("DATO");

                entity.Property(e => e.Dend).HasColumnName("DEND");

                entity.Property(e => e.Dstart).HasColumnName("DSTART");

                entity.Property(e => e.Jobn).HasColumnName("JOBN");

                entity.Property(e => e.Phone).HasColumnName("PHONE");
            });

            modelBuilder.Entity<LikeItem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LikeName)
                    .IsRequired()
                    .HasColumnName("likeName");

                entity.Property(e => e.Qtty).HasColumnName("QTTY");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.LikeItem)
                    .HasForeignKey<LikeItem>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LikeItems_MealsDetail");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Comm2).HasColumnName("COMM2");

                entity.Property(e => e.Del).HasColumnName("DEL");
            });

            modelBuilder.Entity<MaxPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MaxPlan");

                entity.Property(e => e.Branchn).HasColumnName("branchn");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Payment).HasColumnName("payment");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            });

            modelBuilder.Entity<MaxPlanNotAlerg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MaxPlanNotALERG");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.Calories).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Carb).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cholest)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cholest");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Fats).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fiber)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fiber");

                entity.Property(e => e.Kilj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("kilj");

                entity.Property(e => e.Mealtypename).HasMaxLength(50);

                entity.Property(e => e.Potas)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("potas");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Protiens).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sfat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sfat");

                entity.Property(e => e.Sod)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sod");

                entity.Property(e => e.Suger)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("suger");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("FK_dbo.Meals_dbo.MealDay_DayId");

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.UnitTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.Meals_dbo.UnitTypes_UnitTypeId");
            });

            modelBuilder.Entity<MealDay>(entity =>
            {
                entity.ToTable("MealDay");

                entity.Property(e => e.MealDayId).HasColumnName("MealDayID");
            });

            modelBuilder.Entity<MealDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MealDetail");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DelBoy).HasColumnName("DelBOy");

                entity.Property(e => e.Sod).HasColumnName("SOD");

                entity.Property(e => e.St).HasColumnName("ST");
            });

            modelBuilder.Entity<MealType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("TypeID");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<MealsDetail>(entity =>
            {
                entity.ToTable("MealsDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Cat).HasColumnName("cat");

                entity.Property(e => e.Cholest).HasColumnName("cholest");

                entity.Property(e => e.Comm).HasColumnName("comm");

                entity.Property(e => e.Comm2).HasColumnName("comm2");

                entity.Property(e => e.Fiber).HasColumnName("fiber");

                entity.Property(e => e.Gm)
                    .HasMaxLength(255)
                    .HasColumnName("GM");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Kilj).HasColumnName("kilj");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.Potas).HasColumnName("potas");

                entity.Property(e => e.Sfat).HasColumnName("sfat");

                entity.Property(e => e.Sod).HasColumnName("sod");

                entity.Property(e => e.Suger).HasColumnName("suger");
            });

            modelBuilder.Entity<MealsDetail2>(entity =>
            {
                entity.ToTable("MealsDetail2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Gm)
                    .HasMaxLength(255)
                    .HasColumnName("GM");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("ITEM");
            });

            modelBuilder.Entity<MealsDetail4>(entity =>
            {
                entity.ToTable("MealsDetail4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cat).HasColumnName("cat");

                entity.Property(e => e.Cholest).HasColumnName("cholest");

                entity.Property(e => e.Comm).HasColumnName("comm");

                entity.Property(e => e.Comm2).HasColumnName("comm2");

                entity.Property(e => e.Fiber).HasColumnName("fiber");

                entity.Property(e => e.Gm)
                    .HasMaxLength(255)
                    .HasColumnName("GM");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Kilj).HasColumnName("kilj");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.Potas).HasColumnName("potas");

                entity.Property(e => e.Sfat).HasColumnName("sfat");

                entity.Property(e => e.Sod).HasColumnName("sod");

                entity.Property(e => e.Suger).HasColumnName("suger");
            });

            modelBuilder.Entity<Mealsalescount>(entity =>
            {
                entity.HasKey(e => e.Mealidre);

                entity.ToTable("mealsalescount");

                entity.Property(e => e.Mealidre)
                    .ValueGeneratedNever()
                    .HasColumnName("mealidre");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Countofmeal)
                    .HasColumnName("countofmeal")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mealname).HasColumnName("mealname");
            });

            modelBuilder.Entity<MessKot>(entity =>
            {
                entity.ToTable("MessKOT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Cname).HasColumnName("CName");

                entity.Property(e => e.Dt).HasColumnType("datetime");
            });

            modelBuilder.Entity<MessKot222>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MessKOT222");

                entity.Property(e => e.Add1).HasMaxLength(255);

                entity.Property(e => e.Add2).HasMaxLength(255);

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Cname)
                    .HasMaxLength(255)
                    .HasColumnName("CName");

                entity.Property(e => e.ConName).HasMaxLength(255);

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.DelBoy).HasMaxLength(255);

                entity.Property(e => e.DelTime).HasMaxLength(255);

                entity.Property(e => e.Delivery).HasMaxLength(255);

                entity.Property(e => e.Dt).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mobile).HasMaxLength(255);

                entity.Property(e => e.Tag).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<MessKotch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MessKOTch");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Cname).HasColumnName("CName");

                entity.Property(e => e.Dt).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Messlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MESSLOG");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Comp).HasColumnName("comp");

                entity.Property(e => e.Dater)
                    .HasColumnType("datetime")
                    .HasColumnName("dater");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Save1).HasColumnName("save1");

                entity.Property(e => e.Shift).HasColumnName("shift");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MyPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MyPrice");

                entity.Property(e => e.Cpgw)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CPGW");

                entity.Property(e => e.Cplw)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CPLW");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("GW");

                entity.Property(e => e.Lw)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("LW");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTimeId).HasColumnName("DeliveryTimeID");

                entity.Property(e => e.MealId1).HasColumnName("MealID1");

                entity.Property(e => e.MealId2).HasColumnName("MealID2");

                entity.Property(e => e.MealId3).HasColumnName("MealID3");

                entity.Property(e => e.MealId4).HasColumnName("MealID4");

                entity.Property(e => e.MealId5).HasColumnName("MealID5");

                entity.Property(e => e.MealId6).HasColumnName("MealID6");

                entity.Property(e => e.MealId7).HasColumnName("MealID7");

                entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.Orders_dbo.Employees_EmployeeId");

                entity.HasOne(d => d.MealId1Navigation)
                    .WithMany(p => p.OrderMealId1Navigations)
                    .HasForeignKey(d => d.MealId1)
                    .HasConstraintName("FK_dbo.Orders_dbo.Meals_MealID1");

                entity.HasOne(d => d.MealId2Navigation)
                    .WithMany(p => p.OrderMealId2Navigations)
                    .HasForeignKey(d => d.MealId2)
                    .HasConstraintName("FK_dbo.Orders_dbo.Meals_MealID2");

                entity.HasOne(d => d.MealId3Navigation)
                    .WithMany(p => p.OrderMealId3Navigations)
                    .HasForeignKey(d => d.MealId3)
                    .HasConstraintName("FK_dbo.Orders_dbo.Meals_MealID3");

                entity.HasOne(d => d.MealId4Navigation)
                    .WithMany(p => p.OrderMealId4Navigations)
                    .HasForeignKey(d => d.MealId4)
                    .HasConstraintName("FK_dbo.Orders_dbo.Meals_MealID4");

                entity.HasOne(d => d.MealId5Navigation)
                    .WithMany(p => p.OrderMealId5Navigations)
                    .HasForeignKey(d => d.MealId5)
                    .HasConstraintName("FK_dbo.Orders_dbo.Meals_MealID5");

                entity.HasOne(d => d.MealId6Navigation)
                    .WithMany(p => p.OrderMealId6Navigations)
                    .HasForeignKey(d => d.MealId6)
                    .HasConstraintName("FK_dbo.Orders_dbo.Meals_MealID6");

                entity.HasOne(d => d.MealId7Navigation)
                    .WithMany(p => p.OrderMealId7Navigations)
                    .HasForeignKey(d => d.MealId7)
                    .HasConstraintName("FK_dbo.Orders_dbo.Meals_MealID7");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.Delivered).HasColumnName("delivered");

                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_dbo.OrderDetails_dbo.Meals_MealID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_dbo.OrderDetails_dbo.Orders_OrderID");
            });

            modelBuilder.Entity<Paytre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("paytre");

                entity.Property(e => e.Cardt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cardt");

                entity.Property(e => e.Careget)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("careget");

                entity.Property(e => e.Casht)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("casht");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Delvt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("delvt");

                entity.Property(e => e.Excht)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("excht");

                entity.Property(e => e.Expenst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("expenst");

                entity.Property(e => e.Netp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netp");

                entity.Property(e => e.Onlinet)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("onlinet");

                entity.Property(e => e.Picupt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("picupt");

                entity.Property(e => e.Talabt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("talabt");

                entity.Property(e => e.Totalsale)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalsale");

                entity.Property(e => e.Zamatt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("zamatt");
            });

            modelBuilder.Entity<Pickupsh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pickupsh");

                entity.Property(e => e.Dateofpr).HasColumnName("dateofpr");

                entity.Property(e => e.Dilivname).HasColumnName("dilivname");

                entity.Property(e => e.Shift).HasColumnName("shift");
            });

            modelBuilder.Entity<Pitemlist>(entity =>
            {
                entity.ToTable("PITEMLIST");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.F10).HasMaxLength(255);

                entity.Property(e => e.F11).HasMaxLength(255);

                entity.Property(e => e.F12).HasMaxLength(255);

                entity.Property(e => e.F13).HasMaxLength(255);

                entity.Property(e => e.F14).HasMaxLength(255);

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Per100gm).HasColumnName("PER100GM");

                entity.Property(e => e.Per150gm).HasColumnName("PER150GM");

                entity.Property(e => e.Per200gm).HasColumnName("PER200GM");

                entity.Property(e => e.Per250gm).HasColumnName("PER250GM");

                entity.Property(e => e.Per300gm).HasColumnName("PER300GM");

                entity.Property(e => e.Perpcs).HasColumnName("PERPCS");

                entity.Property(e => e.Unit)
                    .HasMaxLength(255)
                    .HasColumnName("UNIT");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.HasKey(e => e.MealId)
                    .HasName("PK_Mealss");

                entity.Property(e => e.MealId)
                    .ValueGeneratedNever()
                    .HasColumnName("MealID");

                entity.Property(e => e.Calories).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Carb).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cholest)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cholest");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Fats).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fiber)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fiber");

                entity.Property(e => e.Kilj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("kilj");

                entity.Property(e => e.Mealtypename).HasMaxLength(50);

                entity.Property(e => e.PlanType).HasMaxLength(50);

                entity.Property(e => e.Potas)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("potas");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Protiens).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sfat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sfat");

                entity.Property(e => e.Sod)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sod");

                entity.Property(e => e.Suger)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("suger");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Planpr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PLANPR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Plname).HasColumnName("PLNAME");

                entity.Property(e => e.Plprice).HasColumnName("PLPRICE");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<Pledger>(entity =>
            {
                entity.ToTable("PLEDGER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Amountmatch).HasColumnName("AMOUNTMATCH");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Comm1).HasColumnName("COMM1");

                entity.Property(e => e.Comm2).HasColumnName("COMM2");

                entity.Property(e => e.Comm3).HasColumnName("COMM3");

                entity.Property(e => e.Comm4).HasColumnName("COMM4");

                entity.Property(e => e.Custpho)
                    .HasMaxLength(50)
                    .HasColumnName("CUSTPHO");

                entity.Property(e => e.Datej)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEJ");

                entity.Property(e => e.Jname).HasColumnName("JNAME");

                entity.Property(e => e.Mainbranch).HasColumnName("MAINBRANCH");

                entity.Property(e => e.Meals).HasColumnName("MEALS");

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.Pickupbranch).HasColumnName("PICKUPBRANCH");

                entity.Property(e => e.Planc).HasColumnName("PLANC");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.BuyingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Calories).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Carb).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fats).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Protiens).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Products");

                entity.Property(e => e.BuyingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Calories).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Carb).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DontMonitorStock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fats).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Protiens).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product2>(entity =>
            {
                entity.ToTable("Product2");

                entity.Property(e => e.BuyingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Calories).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Carb).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fats).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Protiens).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product2s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Product_dbo.ProductCategory_CategoryId");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Product2s)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_dbo.Product_dbo.Supplier_VendorId");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");
            });

            modelBuilder.Entity<ProductTransaction>(entity =>
            {
                entity.ToTable("ProductTransaction");

                entity.Property(e => e.SupplierVendorId).HasColumnName("Supplier_VendorId");

                entity.Property(e => e.TransactionTime).HasColumnType("datetime");

                entity.HasOne(d => d.SupplierVendor)
                    .WithMany(p => p.ProductTransactions)
                    .HasForeignKey(d => d.SupplierVendorId)
                    .HasConstraintName("FK_dbo.ProductTransaction_dbo.Supplier_Supplier_VendorId");
            });

            modelBuilder.Entity<ProductTransactionDetail>(entity =>
            {
                entity.ToTable("ProductTransactionDetail");

                entity.Property(e => e.ProductTransactionId).HasColumnName("ProductTransaction_Id");

                entity.Property(e => e.TransactionTime).HasColumnType("datetime");

                entity.HasOne(d => d.PosItem)
                    .WithMany(p => p.ProductTransactionDetails)
                    .HasForeignKey(d => d.PosItemId)
                    .HasConstraintName("FK_dbo.ProductTransactionDetail_dbo.Product_PosItemId");

                entity.HasOne(d => d.ProductTransaction)
                    .WithMany(p => p.ProductTransactionDetails)
                    .HasForeignKey(d => d.ProductTransactionId)
                    .HasConstraintName("FK_dbo.ProductTransactionDetail_dbo.ProductTransaction_ProductTransaction_Id");
            });

            modelBuilder.Entity<Rd1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RD1");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<Rd2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RD2");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<Rd3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RD3");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<Rd4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RD4");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<Rd5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RD5");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<Rd6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RD6");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<Rd7>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RD7");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<Rd8>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RD8");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<Rd9>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RD9");

                entity.Property(e => e.Cal).HasColumnName("cal");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DayTag).HasMaxLength(255);

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Icode)
                    .HasMaxLength(255)
                    .HasColumnName("ICode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iname)
                    .HasMaxLength(255)
                    .HasColumnName("IName");

                entity.Property(e => e.Pro).HasColumnName("pro");

                entity.Property(e => e.Rem).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<RefundDetail>(entity =>
            {
                entity.ToTable("RefundDetail");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.RefundDate).HasColumnType("datetime");

                entity.Property(e => e.Refundmeth)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("refundmeth");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.RefundDetails)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.RefundDetail_dbo.AppUser_AppUserId");

                entity.HasOne(d => d.BillIrerfrncNavigation)
                    .WithMany(p => p.RefundDetails)
                    .HasForeignKey(d => d.BillIrerfrnc)
                    .HasConstraintName("FK_dbo.RefundDetail_dbo.BillRecored_BillId");
            });

            modelBuilder.Entity<RefundProductDetail>(entity =>
            {
                entity.ToTable("RefundProductDetail");

                entity.HasOne(d => d.BillItemInfo)
                    .WithMany(p => p.RefundProductDetails)
                    .HasForeignKey(d => d.BillItemInfoId)
                    .HasConstraintName("FK_dbo.RefundProductDetail_dbo.BillItemDetail_BillItemInfoId");

                entity.HasOne(d => d.RefundInfo)
                    .WithMany(p => p.RefundProductDetails)
                    .HasForeignKey(d => d.RefundInfoId)
                    .HasConstraintName("FK_dbo.RefundProductDetail_dbo.RefundDetail_RefundInfoId");
            });

            modelBuilder.Entity<RmessKot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RMessKOT");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Cname).HasColumnName("CName");

                entity.Property(e => e.Dt).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<SalesMan>(entity =>
            {
                entity.ToTable("SalesMan");

                entity.Property(e => e.Cnicnumber).HasColumnName("CNICNumber");
            });

            modelBuilder.Entity<Sheet5XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet5$_xlnm#_FilterDatabase");

                entity.Property(e => e._0).HasColumnName("0");

                entity.Property(e => e._01).HasColumnName("01");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._31).HasColumnName("31");

                entity.Property(e => e._780).HasColumnName("780");
            });

            modelBuilder.Entity<Sponser>(entity =>
            {
                entity.ToTable("SPONSERS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Counter).HasColumnName("COUNTER");

                entity.Property(e => e.Discam).HasColumnName("DISCAM");

                entity.Property(e => e.Discount).HasColumnName("DISCOUNT");

                entity.Property(e => e.Extra3).HasColumnName("EXTRA3");

                entity.Property(e => e.Extra4).HasColumnName("EXTRA4");

                entity.Property(e => e.Name).HasColumnName("NAME");
            });

            modelBuilder.Entity<Sslog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SSLOG");

                entity.Property(e => e.CreatedDate).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SelectedDates)
                    .HasMaxLength(255)
                    .HasColumnName("Selected_Dates");

                entity.Property(e => e.TotalPrint)
                    .HasMaxLength(255)
                    .HasColumnName("Total_Print");
            });

            modelBuilder.Entity<Subblier>(entity =>
            {
                entity.HasKey(e => e.SubId);

                entity.ToTable("Subblier");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.Property(e => e.SubAddress)
                    .HasMaxLength(50)
                    .HasColumnName("sub_address");

                entity.Property(e => e.SubName)
                    .HasMaxLength(50)
                    .HasColumnName("sub_name");

                entity.Property(e => e.SubPhone)
                    .HasMaxLength(50)
                    .HasColumnName("sub_phone");
            });

            modelBuilder.Entity<Subduo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUBDUO");

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Custid).HasColumnName("CUSTID");

                entity.Property(e => e.Custmobile).HasColumnName("CUSTMOBILE");

                entity.Property(e => e.Custname).HasColumnName("CUSTNAME");

                entity.Property(e => e.Driver).HasColumnName("DRIVER");

                entity.Property(e => e.Nofdays).HasColumnName("NOFDAYS");
            });

            modelBuilder.Entity<Subinv>(entity =>
            {
                entity.ToTable("SUBINV");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Comm)
                    .HasMaxLength(50)
                    .HasColumnName("COMM");

                entity.Property(e => e.Comm2)
                    .HasMaxLength(50)
                    .HasColumnName("COMM2");

                entity.Property(e => e.Comm3)
                    .HasMaxLength(50)
                    .HasColumnName("COMM3");

                entity.Property(e => e.Company).HasColumnName("COMPANY");

                entity.Property(e => e.Confdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFDATE");

                entity.Property(e => e.Confrm)
                    .HasMaxLength(50)
                    .HasColumnName("CONFRM");

                entity.Property(e => e.Confrmon).HasColumnName("CONFRMON");

                entity.Property(e => e.Custname).HasColumnName("CUSTNAME");

                entity.Property(e => e.Custph).HasColumnName("CUSTPH");

                entity.Property(e => e.Dates)
                    .HasColumnType("datetime")
                    .HasColumnName("DATES");

                entity.Property(e => e.Delvbranch).HasColumnName("DELVBRANCH");

                entity.Property(e => e.Disc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DISC");

                entity.Property(e => e.Discam)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DISCAM");

                entity.Property(e => e.Driver)
                    .HasMaxLength(50)
                    .HasColumnName("DRIVER");

                entity.Property(e => e.Emp).HasColumnName("EMP");

                entity.Property(e => e.InvImg)
                    .HasColumnType("image")
                    .HasColumnName("INV_IMG");

                entity.Property(e => e.Invnum).HasColumnName("INVNUM");

                entity.Property(e => e.Maxin).HasColumnName("MAXIN");

                entity.Property(e => e.Paym).HasColumnName("PAYM");

                entity.Property(e => e.Refrd).HasColumnName("REFRD");

                entity.Property(e => e.Refund)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("REFUND");

                entity.Property(e => e.Refunddt)
                    .HasColumnType("datetime")
                    .HasColumnName("REFUNDDT");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<SubinvR>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("subinv_r");

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Comm)
                    .HasMaxLength(50)
                    .HasColumnName("COMM");

                entity.Property(e => e.Comm2)
                    .HasMaxLength(50)
                    .HasColumnName("COMM2");

                entity.Property(e => e.Comm3)
                    .HasMaxLength(50)
                    .HasColumnName("COMM3");

                entity.Property(e => e.Company).HasColumnName("COMPANY");

                entity.Property(e => e.Confdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFDATE");

                entity.Property(e => e.Confrm)
                    .HasMaxLength(50)
                    .HasColumnName("CONFRM");

                entity.Property(e => e.Confrmon).HasColumnName("CONFRMON");

                entity.Property(e => e.Custname).HasColumnName("CUSTNAME");

                entity.Property(e => e.Custph).HasColumnName("CUSTPH");

                entity.Property(e => e.Dates)
                    .HasColumnType("datetime")
                    .HasColumnName("DATES");

                entity.Property(e => e.Delvbranch).HasColumnName("DELVBRANCH");

                entity.Property(e => e.Disc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DISC");

                entity.Property(e => e.Discam)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DISCAM");

                entity.Property(e => e.Driver)
                    .HasMaxLength(50)
                    .HasColumnName("DRIVER");

                entity.Property(e => e.Emp).HasColumnName("EMP");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InvImg)
                    .HasColumnType("image")
                    .HasColumnName("INV_IMG");

                entity.Property(e => e.Invnum).HasColumnName("INVNUM");

                entity.Property(e => e.Maxin).HasColumnName("MAXIN");

                entity.Property(e => e.Paym).HasColumnName("PAYM");

                entity.Property(e => e.Refrd).HasColumnName("REFRD");

                entity.Property(e => e.Refund)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("REFUND");

                entity.Property(e => e.Refunddt)
                    .HasColumnType("datetime")
                    .HasColumnName("REFUNDDT");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<SubinvRep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUBINV_rep");

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Comm)
                    .HasMaxLength(50)
                    .HasColumnName("COMM");

                entity.Property(e => e.Comm2)
                    .HasMaxLength(50)
                    .HasColumnName("COMM2");

                entity.Property(e => e.Comm3)
                    .HasMaxLength(50)
                    .HasColumnName("COMM3");

                entity.Property(e => e.Company).HasColumnName("COMPANY");

                entity.Property(e => e.Confdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFDATE");

                entity.Property(e => e.Confrm)
                    .HasMaxLength(50)
                    .HasColumnName("CONFRM");

                entity.Property(e => e.Confrmon).HasColumnName("CONFRMON");

                entity.Property(e => e.Custname).HasColumnName("CUSTNAME");

                entity.Property(e => e.Custph).HasColumnName("CUSTPH");

                entity.Property(e => e.Dates)
                    .HasColumnType("datetime")
                    .HasColumnName("DATES");

                entity.Property(e => e.Delvbranch).HasColumnName("DELVBRANCH");

                entity.Property(e => e.Disc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DISC");

                entity.Property(e => e.Discam)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DISCAM");

                entity.Property(e => e.Driver)
                    .HasMaxLength(50)
                    .HasColumnName("DRIVER");

                entity.Property(e => e.Emp).HasColumnName("EMP");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InvImg)
                    .HasColumnType("image")
                    .HasColumnName("INV_IMG");

                entity.Property(e => e.Invnum).HasColumnName("INVNUM");

                entity.Property(e => e.Maxin).HasColumnName("MAXIN");

                entity.Property(e => e.Paym).HasColumnName("PAYM");

                entity.Property(e => e.Refrd).HasColumnName("REFRD");

                entity.Property(e => e.Refund)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("REFUND");

                entity.Property(e => e.Refunddt)
                    .HasColumnType("datetime")
                    .HasColumnName("REFUNDDT");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<Subreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("subreport");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.SubcriptionTypeId).HasColumnName("SubcriptionTypeID");

                entity.Property(e => e.SubscriptionCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SubscriptionDetail>(entity =>
            {
                entity.Property(e => e.SubscriptionDetailId).HasColumnName("SubscriptionDetailID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.MealTypeId).HasColumnName("MealTypeID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SubscriptionType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SubscriptionTypeId).HasColumnName("SubscriptionTypeID");
            });

            modelBuilder.Entity<Suppli>(entity =>
            {
                entity.ToTable("SUPPLI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ext).HasColumnName("EXT");

                entity.Property(e => e.Ext1).HasColumnName("EXT1");

                entity.Property(e => e.Ext2).HasColumnName("EXT2");

                entity.Property(e => e.Gmprice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("GMPRICE");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.Iteminpurch).HasColumnName("ITEMINPURCH");

                entity.Property(e => e.Munit).HasColumnName("MUNIT");

                entity.Property(e => e.Subunit).HasColumnName("SUBUNIT");

                entity.Property(e => e.Sunit)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("SUNIT");

                entity.Property(e => e.Supplires).HasColumnName("SUPPLIRES");

                entity.Property(e => e.Totalunit)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("TOTALUNIT");

                entity.Property(e => e.Tprice)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("TPRICE");

                entity.Property(e => e.Unit).HasColumnName("UNIT");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("PK_dbo.Supplier");

                entity.ToTable("Supplier");
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.Property(e => e.IsSmptSsl).HasColumnName("IsSmptSSL");
            });

            modelBuilder.Entity<T1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t1");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<T10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t10");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<T2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t2");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<T3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t3");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<T4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t4");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<T5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t5");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<T6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t6");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<T7>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t7");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<T8>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t8");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<TempMealsDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempMealsDetail");

                entity.Property(e => e.Gm)
                    .HasMaxLength(255)
                    .HasColumnName("GM");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("ITEM");

                entity.Property(e => e.Kilj).HasColumnName("kilj");

                entity.Property(e => e.Sod).HasColumnName("sod");
            });

            modelBuilder.Entity<Tryy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tryy");

                entity.Property(e => e.Mnme)
                    .IsRequired()
                    .HasColumnName("mnme");
            });

            modelBuilder.Entity<Tw1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw1");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw10");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw11>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw11");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw12>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw12");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw13>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw13");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw14>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw14");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw2");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw3");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw4");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw5");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw6");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw7>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw7");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw8>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw8");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Tw9>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tw9");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meals).HasColumnName("meals");

                entity.Property(e => e.Mqyty).HasColumnName("mqyty");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Salesm).HasColumnName("salesm");

                entity.Property(e => e.Totalq).HasColumnName("totalq");

                entity.Property(e => e.Totalv).HasColumnName("totalv");

                entity.Property(e => e.Totap).HasColumnName("totap");
            });

            modelBuilder.Entity<Udday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Udday");

                entity.Property(e => e.Count).HasColumnName("COUNT");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Custplan).HasColumnName("custplan");
            });

            modelBuilder.Entity<UnitType>(entity =>
            {
                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch).HasColumnName("BRANCH");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.Name).HasColumnName("NAME");
            });

            modelBuilder.Entity<WeeklySalesSupscriptionReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("WEEKLY_SALES_SUPSCRIPTION_REPORT");

                entity.Property(e => e.Branchn).HasColumnName("branchn");

                entity.Property(e => e.Custname).HasColumnName("custname");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Custphone).HasColumnName("custphone");

                entity.Property(e => e.Custplan).HasColumnName("custplan");

                entity.Property(e => e.Mealtypename).HasColumnName("mealtypename");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
