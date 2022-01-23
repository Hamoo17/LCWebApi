using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class lowcalor_lowcaloriesdbContext : DbContext
    {
        public lowcalor_lowcaloriesdbContext()
        {
        }

        public lowcalor_lowcaloriesdbContext(DbContextOptions<lowcalor_lowcaloriesdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<AgentBranch> AgentBranches { get; set; }
        public virtual DbSet<AgentBranchDetail> AgentBranchDetails { get; set; }
        public virtual DbSet<AgentEmirate> AgentEmirates { get; set; }
        public virtual DbSet<AgentReport> AgentReports { get; set; }
        public virtual DbSet<AllCountry> AllCountries { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AreasNew> AreasNews { get; set; }
        public virtual DbSet<BagEnable> BagEnables { get; set; }
        public virtual DbSet<BootQuestion> BootQuestions { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchCashier> BranchCashiers { get; set; }
        public virtual DbSet<BranchDriver> BranchDrivers { get; set; }
        public virtual DbSet<Calory> Calories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CustMealNew> CustMealNews { get; set; }
        public virtual DbSet<CustomMealPrice> CustomMealPrices { get; set; }
        public virtual DbSet<CustomMenu> CustomMenus { get; set; }
        public virtual DbSet<CustomPlanPrice> CustomPlanPrices { get; set; }
        public virtual DbSet<CustomerKot> CustomerKots { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<DayMeal> DayMeals { get; set; }
        public virtual DbSet<DayMealCustom> DayMealCustoms { get; set; }
        public virtual DbSet<DayMealNew> DayMealNews { get; set; }
        public virtual DbSet<DeliveryDay> DeliveryDays { get; set; }
        public virtual DbSet<DisLike> DisLikes { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Emara> Emaras { get; set; }
        public virtual DbSet<Emirate> Emirates { get; set; }
        public virtual DbSet<EmirateAppointment> EmirateAppointments { get; set; }
        public virtual DbSet<EmirateAppointmentTime> EmirateAppointmentTimes { get; set; }
        public virtual DbSet<FailedJob> FailedJobs { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<GiftCode> GiftCodes { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MaxLgCutom> MaxLgCutoms { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<MealCategory> MealCategories { get; set; }
        public virtual DbSet<MealDetail> MealDetails { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuPdf> MenuPdfs { get; set; }
        public virtual DbSet<Migration> Migrations { get; set; }
        public virtual DbSet<NewMenu> NewMenus { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationMessage> NotificationMessages { get; set; }
        public virtual DbSet<Opening> Openings { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDay> OrderDays { get; set; }
        public virtual DbSet<PasswordReset> PasswordResets { get; set; }
        public virtual DbSet<PdfProgramLink> PdfProgramLinks { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<PlanOption> PlanOptions { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<ProgramCustom> ProgramCustoms { get; set; }
        public virtual DbSet<ProgramCustomsDetail> ProgramCustomsDetails { get; set; }
        public virtual DbSet<ProgramCustomsPlan> ProgramCustomsPlans { get; set; }
        public virtual DbSet<ProgramMenu> ProgramMenus { get; set; }
        public virtual DbSet<Proseger> Prosegers { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Sheet3> Sheet3s { get; set; }
        public virtual DbSet<SiteImage> SiteImages { get; set; }
        public virtual DbSet<SpecialCutomNews> SpecialCutomNews { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<SubscriptionDay> SubscriptionDays { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SysPlan> SysPlans { get; set; }
        public virtual DbSet<SysPlanOption> SysPlanOptions { get; set; }
        public virtual DbSet<SysProgram> SysPrograms { get; set; }
        public virtual DbSet<Table16> Table16s { get; set; }
        public virtual DbSet<Tempplan> Tempplans { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCid> UserCids { get; set; }
        public virtual DbSet<UserDevice> UserDevices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;database=lowcalor_lowcaloriesdb;user=root;persist security info=False;connect timeout=300", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("about");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionAr)
                    .HasColumnType("text")
                    .HasColumnName("description_ar");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("header");

                entity.Property(e => e.HeaderAr)
                    .HasColumnType("text")
                    .HasColumnName("header_ar");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("addresses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .HasColumnName("area");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Emirate).HasColumnName("emirate");

                entity.Property(e => e.FlatNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("flat_number");

                entity.Property(e => e.Floor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("floor");

                entity.Property(e => e.LandMark)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("land_mark");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("agents");

                entity.HasIndex(e => e.BranchId, "branch_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentId).HasColumnName("agent_id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Agents)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("agents_ibfk_1");
            });

            modelBuilder.Entity<AgentBranch>(entity =>
            {
                entity.ToTable("agent_branches");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.AgentEmirateId, "agent_emirate_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentEmirateId).HasColumnName("agent_emirate_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.HasOne(d => d.AgentEmirate)
                    .WithMany(p => p.AgentBranches)
                    .HasForeignKey(d => d.AgentEmirateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("agent_branches_ibfk_1");
            });

            modelBuilder.Entity<AgentBranchDetail>(entity =>
            {
                entity.ToTable("agent_branch_details");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.AgentBranchId).HasColumnName("agent_branch_id");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("area");

                entity.Property(e => e.BankIban)
                    .HasMaxLength(255)
                    .HasColumnName("bank_iban");

                entity.Property(e => e.BankName)
                    .HasMaxLength(255)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BankNumber)
                    .HasMaxLength(255)
                    .HasColumnName("bank_number");

                entity.Property(e => e.HeadChefName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("head_chef_name");

                entity.Property(e => e.HeadChefPhone)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("head_chef_phone");

                entity.Property(e => e.HeadChefWhatsapp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("head_chef_whatsapp");

                entity.Property(e => e.LandLine)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("land_line");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.ManagerMobile)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("manager_mobile");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("manager_name");

                entity.Property(e => e.ManagerWhatsapp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("manager_whatsapp");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("mobile");
            });

            modelBuilder.Entity<AgentEmirate>(entity =>
            {
                entity.ToTable("agent_emirates");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("name");

                entity.Property(e => e.Program)
                    .IsRequired()
                    .HasColumnType("enum('lc','ch')")
                    .HasColumnName("program")
                    .HasDefaultValueSql("'lc'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<AgentReport>(entity =>
            {
                entity.ToTable("agent_reports");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .HasColumnName("branch");

                entity.Property(e => e.ClientCid)
                    .HasMaxLength(255)
                    .HasColumnName("client_cid");

                entity.Property(e => e.ClientMobile)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("client_mobile");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .HasColumnName("client_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.OrderDetail)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("order_detail");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<AllCountry>(entity =>
            {
                entity.ToTable("all_countries");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.PhoneCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("phoneCode");

                entity.Property(e => e.Sortname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("sortname");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("areas");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.EmirateId, "areas_emirate_id_foreign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmirateId).HasColumnName("emirate_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Time)
                    .HasMaxLength(191)
                    .HasColumnName("time");
            });

            modelBuilder.Entity<AreasNew>(entity =>
            {
                entity.ToTable("areas_new");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.EmaraId, "emara_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmaraId).HasColumnName("emara_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("time");

                entity.HasOne(d => d.Emara)
                    .WithMany(p => p.AreasNews)
                    .HasForeignKey(d => d.EmaraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("areas_new_ibfk_1");
            });

            modelBuilder.Entity<BagEnable>(entity =>
            {
                entity.ToTable("bag_enables");

                entity.HasIndex(e => e.EmaraId, "emara_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BagPrice)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("bag_price");

                entity.Property(e => e.EmaraId).HasColumnName("emara_id");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.HasOne(d => d.Emara)
                    .WithMany(p => p.BagEnables)
                    .HasForeignKey(d => d.EmaraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bag_enables_ibfk_1");
            });

            modelBuilder.Entity<BootQuestion>(entity =>
            {
                entity.ToTable("boot_questions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Number)
                    .HasMaxLength(1000)
                    .HasColumnName("number");

                entity.Property(e => e.Parent)
                    .HasMaxLength(255)
                    .HasColumnName("parent");

                entity.Property(e => e.Question)
                    .HasColumnType("text")
                    .HasColumnName("question")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.QuestionAr)
                    .HasColumnType("text")
                    .HasColumnName("question_ar");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("enum('question','answer')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'question'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("branches");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.EmirateId).HasColumnName("emirate_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<BranchCashier>(entity =>
            {
                entity.ToTable("branch_cashiers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchDetailId).HasColumnName("branch_detail_id");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Whatsapp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("whatsapp");
            });

            modelBuilder.Entity<BranchDriver>(entity =>
            {
                entity.ToTable("branch_drivers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchDetailId).HasColumnName("branch_detail_id");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Whatsapp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("whatsapp");
            });

            modelBuilder.Entity<Calory>(entity =>
            {
                entity.ToTable("calories");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.MealId, "calories_meal_id_foreign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Calories)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("calories");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("price");

                entity.Property(e => e.Quantity)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("quantity");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("cities");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.StateId).HasColumnName("state_id");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("companies");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Company1)
                    .IsRequired()
                    .HasColumnType("enum('LC','CH')")
                    .HasColumnName("company");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Plans)
                    .HasMaxLength(255)
                    .HasColumnName("plans");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<ContactU>(entity =>
            {
                entity.ToTable("contact_us");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(1000)
                    .HasColumnName("address")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.AddressEn)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("address_en");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("branch");

                entity.Property(e => e.BranchAr)
                    .HasMaxLength(255)
                    .HasColumnName("branch_ar")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("location");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .HasColumnName("mail");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("countries");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.Property(e => e.Phonecode).HasColumnName("phonecode");

                entity.Property(e => e.Sortname)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("sortname");
            });

            modelBuilder.Entity<CustMealNew>(entity =>
            {
                entity.ToTable("cust_meal_new");

                entity.HasIndex(e => e.CategoryId, "category_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.MaxMeal)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("max_meal")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MaxSide)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("max_side")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MealDescription)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("meal_description");

                entity.Property(e => e.MealDescriptionAr)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("meal_description_ar");

                entity.Property(e => e.MealName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meal_name");

                entity.Property(e => e.MealNameAr)
                    .HasMaxLength(255)
                    .HasColumnName("meal_name_ar");

                entity.Property(e => e.MealType)
                    .HasMaxLength(255)
                    .HasColumnName("meal_type");

                entity.Property(e => e.MealUnit)
                    .IsRequired()
                    .HasColumnType("enum('GM','PCS')")
                    .HasColumnName("meal_unit");

                entity.Property(e => e.PlanId)
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SideUnit)
                    .HasColumnType("enum('GM','PCS')")
                    .HasColumnName("side_unit")
                    .HasDefaultValueSql("'GM'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<CustomMealPrice>(entity =>
            {
                entity.ToTable("custom_meal_prices");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.FiveMeal).HasColumnName("five_meal");

                entity.Property(e => e.FourMeal).HasColumnName("four_meal");

                entity.Property(e => e.OneMeal).HasColumnName("one_meal");

                entity.Property(e => e.SixMeal).HasColumnName("six_meal");

                entity.Property(e => e.ThreeMeal).HasColumnName("three_meal");

                entity.Property(e => e.TwoMeal).HasColumnName("two_meal");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('Gain Weight','Loss Weight')")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CustomMenu>(entity =>
            {
                entity.ToTable("custom_menu");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("img");

                entity.Property(e => e.MealCalories).HasColumnName("meal_calories");

                entity.Property(e => e.MealCarb).HasColumnName("meal_carb");

                entity.Property(e => e.MealDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meal_description");

                entity.Property(e => e.MealDiscriptionAr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meal_discription_ar");

                entity.Property(e => e.MealName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meal_name");

                entity.Property(e => e.MealNameAr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meal_name_ar");

                entity.Property(e => e.MealNumber).HasColumnName("meal_number");

                entity.Property(e => e.MealPrice)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meal_price");

                entity.Property(e => e.MealType)
                    .IsRequired()
                    .HasColumnType("enum('Meal 1','Meal 2','Meal 3','Meal 4','Meal 5','Meal 6','Meal 7','Snack 1','Snack 2','Snack 3')")
                    .HasColumnName("meal_type");

                entity.Property(e => e.MealUnit)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("meal_unit");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.CustomMenus)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("custom_menu_ibfk_1");
            });

            modelBuilder.Entity<CustomPlanPrice>(entity =>
            {
                entity.ToTable("custom_plan_prices");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.FiveMeal).HasColumnName("five_meal");

                entity.Property(e => e.FourMeal).HasColumnName("four_meal");

                entity.Property(e => e.OneMeal).HasColumnName("one_meal");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.SixMeal).HasColumnName("six_meal");

                entity.Property(e => e.ThreeMeal).HasColumnName("three_meal");

                entity.Property(e => e.TwoMeal).HasColumnName("two_meal");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.CustomPlanPrices)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("custom_plan_prices_ibfk_1");
            });

            modelBuilder.Entity<CustomerKot>(entity =>
            {
                entity.ToTable("customer_kots");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .HasColumnName("branch")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.ClientAddress)
                    .HasMaxLength(255)
                    .HasColumnName("client_address")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.ClientCid)
                    .HasMaxLength(191)
                    .HasColumnName("client_cid")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.ClientMobile)
                    .HasMaxLength(255)
                    .HasColumnName("client_mobile")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .HasColumnName("client_name")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.ClientPhone)
                    .HasMaxLength(255)
                    .HasColumnName("client_phone")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.ClientPlan)
                    .HasMaxLength(255)
                    .HasColumnName("client_plan")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.Driver)
                    .HasMaxLength(255)
                    .HasColumnName("driver")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.RemainingDays)
                    .HasMaxLength(255)
                    .HasColumnName("remaining_days")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("days");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DayMeal>(entity =>
            {
                entity.ToTable("day_meal");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.DayId, "day_meal_day_id_index");

                entity.HasIndex(e => e.MealId, "day_meal_meal_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.MealId).HasColumnName("meal_id");
            });

            modelBuilder.Entity<DayMealCustom>(entity =>
            {
                entity.ToTable("day_meal_custom");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.DayId, "day_id");

                entity.HasIndex(e => e.MealCustomId, "meal_custom_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.MealCustomId).HasColumnName("meal_custom_id");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.DayMealCustoms)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("day_meal_custom_ibfk_1");

                entity.HasOne(d => d.MealCustom)
                    .WithMany(p => p.DayMealCustoms)
                    .HasForeignKey(d => d.MealCustomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("day_meal_custom_ibfk_2");
            });

            modelBuilder.Entity<DayMealNew>(entity =>
            {
                entity.ToTable("day_meal_new");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.DayId, "day_id");

                entity.HasIndex(e => e.MealNewId, "meal_new_id");

                entity.HasIndex(e => e.SysProgramId, "sys_program_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.MealNewId).HasColumnName("meal_new_id");

                entity.Property(e => e.SysProgramId).HasColumnName("sys_program_id");
            });

            modelBuilder.Entity<DeliveryDay>(entity =>
            {
                entity.ToTable("delivery_days");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("number");
            });

            modelBuilder.Entity<DisLike>(entity =>
            {
                entity.ToTable("dis_likes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("drivers");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.BranchId, "branch_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("drivers_ibfk_1");
            });

            modelBuilder.Entity<Emara>(entity =>
            {
                entity.ToTable("emara");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("ar_name");

                entity.Property(e => e.EnName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("en_name");

                entity.Property(e => e.InbodyPrice)
                    .HasMaxLength(255)
                    .HasColumnName("inbody_price")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Emirate>(entity =>
            {
                entity.ToTable("emirates");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("ar_name");

                entity.Property(e => e.EnName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("en_name");
            });

            modelBuilder.Entity<EmirateAppointment>(entity =>
            {
                entity.ToTable("emirate_appointments");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Day)
                    .HasColumnType("enum('SATURDAY','SUNDAY','MONDAY','TUSEDAY','WEDNESDAY','THURSDAY','FRIDAY')")
                    .HasColumnName("day");

                entity.Property(e => e.EmaraId).HasColumnName("emara_id");

                entity.Property(e => e.MaxPeople)
                    .HasColumnName("max_people")
                    .HasDefaultValueSql("'10'");
            });

            modelBuilder.Entity<EmirateAppointmentTime>(entity =>
            {
                entity.ToTable("emirate_appointment_times");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmirateAppointmentId).HasColumnName("emirate_appointment_id");

                entity.Property(e => e.TimeFrom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("time_from");

                entity.Property(e => e.TimeTo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("time_to");
            });

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Connection)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("connection");

                entity.Property(e => e.Exception)
                    .IsRequired()
                    .HasColumnName("exception");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnName("payload");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("queue");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.ToTable("galleries");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ProgramId, "galleries_program_id_foreign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Img)
                    .HasMaxLength(191)
                    .HasColumnName("img");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<GiftCode>(entity =>
            {
                entity.ToTable("gift_codes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvailableForPlans)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("available_for_plans");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasColumnType("enum('branch_all','head_office')")
                    .HasColumnName("flag")
                    .HasDefaultValueSql("'branch_all'");

                entity.Property(e => e.NoOfUse).HasColumnName("no_of_use");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("enum('Active','Not Active')")
                    .HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('CUSTOM','NORMAL')")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("jobs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Queue, "jobs_queue_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attempts).HasColumnName("attempts");

                entity.Property(e => e.AvailableAt).HasColumnName("available_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnName("payload");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("queue");

                entity.Property(e => e.ReservedAt).HasColumnName("reserved_at");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("locations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.EmirateId, "emirate_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("area_id");

                entity.Property(e => e.EmirateId).HasColumnName("emirate_id");

                entity.Property(e => e.Landmark)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("landmark");

                entity.Property(e => e.PropertyNumber)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("property_number");
            });

            modelBuilder.Entity<MaxLgCutom>(entity =>
            {
                entity.ToTable("max_lg_cutom");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.GainMax).HasColumnName("gain_max");

                entity.Property(e => e.LossMax).HasColumnName("loss_max");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.ToTable("meals");

                entity.HasCharSet("armscii8")
                    .UseCollation("armscii8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(255)
                    .HasColumnName("name_ar")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("price")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");
            });

            modelBuilder.Entity<MealCategory>(entity =>
            {
                entity.ToTable("meal_categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("level")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(255)
                    .HasColumnName("name_ar");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("enum('meal','snack')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'meal'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<MealDetail>(entity =>
            {
                entity.ToTable("meal_details");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Calories).HasColumnName("calories");

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Fat).HasColumnName("fat");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("item");

                entity.Property(e => e.Kilj)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("kilj");

                entity.Property(e => e.Protein).HasColumnName("protein");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasColumnType("enum('GM','PCS')")
                    .HasColumnName("unit")
                    .HasDefaultValueSql("'GM'");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menus");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Img)
                    .HasMaxLength(191)
                    .HasColumnName("img");

                entity.Property(e => e.MealCalories).HasColumnName("meal_calories");

                entity.Property(e => e.MealCarb).HasColumnName("meal_carb");

                entity.Property(e => e.MealDescription)
                    .HasMaxLength(191)
                    .HasColumnName("meal_description");

                entity.Property(e => e.MealDiscriptionAr)
                    .HasMaxLength(255)
                    .HasColumnName("meal_discription_ar")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MealName)
                    .HasMaxLength(191)
                    .HasColumnName("meal_name");

                entity.Property(e => e.MealNameAr)
                    .HasMaxLength(255)
                    .HasColumnName("meal_name_ar")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MealNumber).HasColumnName("meal_number");

                entity.Property(e => e.MealPrice)
                    .HasMaxLength(191)
                    .HasColumnName("meal_price");

                entity.Property(e => e.MealType)
                    .HasColumnType("enum('Meal 1','Meal 2','Meal 3','Meal 4','Meal 5','Meal 6','Meal 7','Snack 1','Snack 2','Snack 3')")
                    .HasColumnName("meal_type");

                entity.Property(e => e.MealUnit)
                    .HasMaxLength(191)
                    .HasColumnName("meal_unit");

                entity.Property(e => e.Popular).HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MenuPdf>(entity =>
            {
                entity.ToTable("menu_pdf");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PdfLink)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("pdf_link");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<NewMenu>(entity =>
            {
                entity.ToTable("new_menus");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.Img)
                    .HasMaxLength(1000)
                    .HasColumnName("img");

                entity.Property(e => e.MealCalories).HasColumnName("meal_calories");

                entity.Property(e => e.MealCarb).HasColumnName("meal_carb");

                entity.Property(e => e.MealDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("meal_description");

                entity.Property(e => e.MealDiscriptionAr)
                    .HasMaxLength(255)
                    .HasColumnName("meal_discription_ar");

                entity.Property(e => e.MealName)
                    .HasMaxLength(191)
                    .HasColumnName("meal_name");

                entity.Property(e => e.MealNameAr)
                    .HasMaxLength(255)
                    .HasColumnName("meal_name_ar");

                entity.Property(e => e.MealNumber).HasColumnName("meal_number");

                entity.Property(e => e.MealPrice)
                    .HasMaxLength(191)
                    .HasColumnName("meal_price")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.MealType)
                    .HasColumnType("enum('Meal 1','Meal 2','Meal 3','Meal 4','Meal 5','Meal 6','Meal 7','Snack 1','Snack 2','Snack 3')")
                    .HasColumnName("meal_type");

                entity.Property(e => e.MealUnit)
                    .HasMaxLength(191)
                    .HasColumnName("meal_unit");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notifications");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Audio)
                    .HasMaxLength(255)
                    .HasColumnName("audio")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("content")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("title")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("type")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<NotificationMessage>(entity =>
            {
                entity.ToTable("notification_messages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("enum('SIGNUP','SendMail','Payment','SpecialCustom')")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<Opening>(entity =>
            {
                entity.ToTable("opening");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Day)
                    .HasMaxLength(191)
                    .HasColumnName("day");

                entity.Property(e => e.Time)
                    .HasMaxLength(191)
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeId).HasColumnName("code_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.CustomProgramId).HasColumnName("custom_program_id");

                entity.Property(e => e.DaysCount)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("days_count");

                entity.Property(e => e.DeliveryDays)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("delivery_days");

                entity.Property(e => e.GrandTotal)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("grand_total");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MealsCount)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meals_count");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("price")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SnacksCount)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("snacks_count");

                entity.Property(e => e.StartDeliveryDay)
                    .HasColumnType("date")
                    .HasColumnName("start_delivery_day");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<OrderDay>(entity =>
            {
                entity.ToTable("order_days");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("day");

                entity.Property(e => e.MainUnit)
                    .IsRequired()
                    .HasColumnType("enum('GM','PCS','NONE')")
                    .HasColumnName("main_unit")
                    .HasDefaultValueSql("'NONE'");

                entity.Property(e => e.MaxMain)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("max_main");

                entity.Property(e => e.MaxSide)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("max_side");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.SideUnit)
                    .IsRequired()
                    .HasColumnType("enum('GM','PCS','NONE')")
                    .HasColumnName("side_unit")
                    .HasDefaultValueSql("'NONE'");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("enum('MEAL','SNACK')")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Email, "password_resets_email_index");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("token");
            });

            modelBuilder.Entity<PdfProgramLink>(entity =>
            {
                entity.ToTable("pdf_program_links");

                entity.HasIndex(e => e.ProgramId, "program_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("link");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("plans");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ProgramId, "plans_program_id_foreign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOfMeals).HasColumnName("number_of_meals");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<PlanOption>(entity =>
            {
                entity.ToTable("plan__options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.PlanId, "plan__options_plan_id_foreign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOfDays).HasColumnName("number_of_days");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Price)
                    .HasPrecision(9, 2)
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.ToTable("programs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("ar_description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ArName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("ar_name");

                entity.Property(e => e.EnDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("en_description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EnName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("en_name");

                entity.Property(e => e.Img)
                    .HasMaxLength(191)
                    .HasColumnName("img")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ProgramCustom>(entity =>
            {
                entity.ToTable("program_customs");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArDescription)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ar_description");

                entity.Property(e => e.ArName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ar_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.EnDescription)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("en_description");

                entity.Property(e => e.EnName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("en_name");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .HasColumnName("icon");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("img");

                entity.Property(e => e.OrderBy)
                    .HasMaxLength(11)
                    .HasColumnName("orderBy");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProgramCustomsDetail>(entity =>
            {
                entity.ToTable("program_customs_details");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.NumberDays)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("number_days");

                entity.Property(e => e.NumberMeals)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("number_meals");

                entity.Property(e => e.NumberSnacks)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("number_snacks");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.StartDay).HasColumnName("start_day");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.ProgramCustomsDetails)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("program_customs_details_ibfk_1");
            });

            modelBuilder.Entity<ProgramCustomsPlan>(entity =>
            {
                entity.ToTable("program_customs_plans");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CustomProgramId, "custom_program_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomProgramId).HasColumnName("custom_program_id");

                entity.Property(e => e.MaxCarb).HasColumnName("max_carb");

                entity.Property(e => e.MaxProtein).HasColumnName("max_protein");

                entity.Property(e => e.Plan)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("plan");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.CustomProgram)
                    .WithMany(p => p.ProgramCustomsPlans)
                    .HasForeignKey(d => d.CustomProgramId)
                    .HasConstraintName("program_customs_plans_ibfk_1");
            });

            modelBuilder.Entity<ProgramMenu>(entity =>
            {
                entity.ToTable("program_menu");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.MealId, "program_menu_meal_id_foreign");

                entity.HasIndex(e => e.ProgramId, "program_menu_program_id_foreign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");
            });

            modelBuilder.Entity<Proseger>(entity =>
            {
                entity.ToTable("proseger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionAr)
                    .HasColumnType("text")
                    .HasColumnName("description_ar")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("header");

                entity.Property(e => e.HeaderAr)
                    .HasMaxLength(255)
                    .HasColumnName("header_ar")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("image");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("settings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BagPrice)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("bag_price")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DemoModalText)
                    .HasMaxLength(1000)
                    .HasColumnName("demo_modal_text");

                entity.Property(e => e.SnacksPrice).HasColumnName("snacks_price");

                entity.Property(e => e.Vat)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("vat");
            });

            modelBuilder.Entity<Sheet3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sheet3");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.C).HasMaxLength(8);

                entity.Property(e => e.D).HasMaxLength(200);

                entity.Property(e => e.E).HasMaxLength(153);

                entity.Property(e => e.F).HasMaxLength(7);

                entity.Property(e => e.G).HasMaxLength(7);
            });

            modelBuilder.Entity<SiteImage>(entity =>
            {
                entity.ToTable("site_images");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("img");

                entity.Property(e => e.Page)
                    .IsRequired()
                    .HasColumnType("enum('LOGO','LOGIN','REGISTER','ABOUT','CONTACT','TERMS','HEADER')")
                    .HasColumnName("page");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<SpecialCutomNews>(entity =>
            {
                entity.ToTable("special_cutom_news");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.AreYouAllergicToSomeMeals)
                    .HasMaxLength(255)
                    .HasColumnName("are_you_allergic_to_some_meals");

                entity.Property(e => e.CalorieNumber).HasColumnName("calorie_number");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.DailyActivity)
                    .HasMaxLength(255)
                    .HasColumnName("daily_activity");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FavProgram)
                    .HasMaxLength(255)
                    .HasColumnName("fav_program");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("full_name");

                entity.Property(e => e.HaveAnyInfections)
                    .HasMaxLength(1000)
                    .HasColumnName("have_any_infections");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.HourInExercise).HasColumnName("hour_in_exercise");

                entity.Property(e => e.MealsYouPreferCount).HasColumnName("meals_you_prefer_count");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("phone")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PracticeSport)
                    .HasMaxLength(100)
                    .HasColumnName("practice_sport");

                entity.Property(e => e.PractiseInWeek).HasColumnName("practise_in_week");

                entity.Property(e => e.SnacksYouPreferCount).HasColumnName("snacks_you_prefer_count");

                entity.Property(e => e.TypeOfSport)
                    .HasMaxLength(100)
                    .HasColumnName("type_of_sport");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Whatsapp)
                    .HasMaxLength(255)
                    .HasColumnName("whatsapp")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("states");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.ToTable("subscriptions");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CodeId, "subscriptions_code_id_foreign");

                entity.HasIndex(e => e.LocationId, "subscriptions_location_id_foreign");

                entity.HasIndex(e => e.OptionId, "subscriptions_option_id_foreign");

                entity.HasIndex(e => e.UserId, "subscriptions_user_id_foreign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentId).HasColumnName("agent_id");

                entity.Property(e => e.Bag)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("bag")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnType("enum('yes','no')")
                    .HasColumnName("branch")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.CodeId).HasColumnName("code_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Custom)
                    .HasColumnType("enum('yes','no')")
                    .HasColumnName("custom");

                entity.Property(e => e.DaysOfWeek)
                    .HasMaxLength(191)
                    .HasColumnName("days_of_week");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DeliveryStartingDay)
                    .HasColumnType("date")
                    .HasColumnName("delivery_starting_day");

                entity.Property(e => e.DisLikeUser)
                    .HasMaxLength(1000)
                    .HasColumnName("dis_like_user");

                entity.Property(e => e.Dislike)
                    .HasMaxLength(191)
                    .HasColumnName("dislike");

                entity.Property(e => e.FullPlanName)
                    .HasMaxLength(255)
                    .HasColumnName("full_plan_name");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(191)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MastercardResultIndicator)
                    .HasMaxLength(250)
                    .HasColumnName("mastercard_resultIndicator")
                    .UseCollation("armscii8_general_ci")
                    .HasCharSet("armscii8");

                entity.Property(e => e.MastercardResultSessionVersion)
                    .HasMaxLength(250)
                    .HasColumnName("mastercard_result_session_version")
                    .UseCollation("armscii8_general_ci")
                    .HasCharSet("armscii8");

                entity.Property(e => e.MastercardSessionId)
                    .HasMaxLength(250)
                    .HasColumnName("mastercard_session_id");

                entity.Property(e => e.MastercardSessionVersion)
                    .HasMaxLength(2050)
                    .HasColumnName("mastercard_session_version");

                entity.Property(e => e.MastercardSuccessIndicator)
                    .HasMaxLength(250)
                    .HasColumnName("mastercard_successIndicator");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasColumnType("enum('0','1','2')")
                    .HasColumnName("mode")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Note)
                    .HasMaxLength(191)
                    .HasColumnName("note");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(255)
                    .HasColumnName("order_id");

                entity.Property(e => e.OrderNotes)
                    .HasMaxLength(1000)
                    .HasColumnName("order_notes");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Price)
                    .HasPrecision(9, 2)
                    .HasColumnName("price");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('stoped','working','pending')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'pending'");

                entity.Property(e => e.SubFrom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("sub_from")
                    .HasDefaultValueSql("'web'");

                entity.Property(e => e.SubscriptionsNote)
                    .HasMaxLength(191)
                    .HasColumnName("subscriptions_note");

                entity.Property(e => e.TotalPrice)
                    .HasPrecision(9, 2)
                    .HasColumnName("total_price");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedText)
                    .HasColumnType("text")
                    .HasColumnName("updated_text");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Vat)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("vat")
                    .HasDefaultValueSql("'0.05'");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("enum('v1','v2','v3')")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'v1'");
            });

            modelBuilder.Entity<SubscriptionDay>(entity =>
            {
                entity.ToTable("subscription_days");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.GramsId, "subscription_days_grams_id_foreign");

                entity.HasIndex(e => e.MealId, "subscription_days_meal_id_foreign");

                entity.HasIndex(e => e.SubscriptionId, "subscription_days_subscription_id_foreign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Carb)
                    .HasMaxLength(191)
                    .HasColumnName("carb");

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.GramsId).HasColumnName("grams_id");

                entity.Property(e => e.MealGeneralId).HasColumnName("meal_general_id");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.Protein)
                    .HasMaxLength(50)
                    .HasColumnName("protein");

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.ToTable("survey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Clinic)
                    .HasMaxLength(255)
                    .HasColumnName("clinic");

                entity.Property(e => e.ClinicReason)
                    .HasMaxLength(255)
                    .HasColumnName("clinic_reason");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomerService)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("customer_service");

                entity.Property(e => e.CustomerServiceReason)
                    .HasMaxLength(255)
                    .HasColumnName("customer_service_reason");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("delivery");

                entity.Property(e => e.DeliveryReason)
                    .HasMaxLength(255)
                    .HasColumnName("delivery_reason");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("mobile");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .HasColumnName("notes");

                entity.Property(e => e.Quality)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("quality");

                entity.Property(e => e.QualityReason)
                    .HasMaxLength(255)
                    .HasColumnName("quality_reason");

                entity.Property(e => e.ReachTargets)
                    .HasMaxLength(255)
                    .HasColumnName("reach_targets");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<SysPlan>(entity =>
            {
                entity.ToTable("sys_plans");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.SysProgramId, "sys_program_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOfMeals).HasColumnName("number_of_meals");

                entity.Property(e => e.SysProgramId).HasColumnName("sys_program_id");
            });

            modelBuilder.Entity<SysPlanOption>(entity =>
            {
                entity.ToTable("sys_plan_options");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.SysPlanId, "sys_plan_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.NumberOfDays).HasColumnName("number_of_days");

                entity.Property(e => e.Price)
                    .HasPrecision(9, 2)
                    .HasColumnName("price");

                entity.Property(e => e.SysPlanId).HasColumnName("sys_plan_id");
            });

            modelBuilder.Entity<SysProgram>(entity =>
            {
                entity.ToTable("sys_program");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ArDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("ar_description");

                entity.Property(e => e.ArName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("ar_name");

                entity.Property(e => e.EnDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("en_description");

                entity.Property(e => e.EnName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("en_name");

                entity.Property(e => e.Img)
                    .HasMaxLength(191)
                    .HasColumnName("img");

                entity.Property(e => e.MaxMeals)
                    .HasMaxLength(255)
                    .HasColumnName("max_meals");

                entity.Property(e => e.MinMeals)
                    .HasMaxLength(255)
                    .HasColumnName("min_meals");

                entity.Property(e => e.NumberSnacks)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("number_snacks")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderBy).HasColumnName("orderBy");
            });

            modelBuilder.Entity<Table16>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table 16");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Breakfast)
                    .HasMaxLength(30)
                    .HasColumnName("BREAKFAST");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.Dinner)
                    .HasMaxLength(45)
                    .HasColumnName("DINNER");

                entity.Property(e => e.Doc)
                    .HasMaxLength(9)
                    .HasColumnName("doc");

                entity.Property(e => e.Lunch)
                    .HasMaxLength(65)
                    .HasColumnName("LUNCH");

                entity.Property(e => e.M4).HasMaxLength(63);

                entity.Property(e => e.M5).HasMaxLength(49);

                entity.Property(e => e.M6).HasMaxLength(43);
            });

            modelBuilder.Entity<Tempplan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempplan");

                entity.HasCharSet("armscii8")
                    .UseCollation("armscii8_general_ci");

                entity.Property(e => e.Carb)
                    .HasMaxLength(191)
                    .HasColumnName("carb");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.DayNumber).HasColumnName("day_number");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.MealType)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("meal_type");

                entity.Property(e => e.Protein)
                    .HasMaxLength(191)
                    .HasColumnName("protein");
            });

            modelBuilder.Entity<Term>(entity =>
            {
                entity.ToTable("terms");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionAr)
                    .HasColumnType("text")
                    .HasColumnName("description_ar");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("header");

                entity.Property(e => e.HeaderAr)
                    .HasColumnType("text")
                    .HasColumnName("header_ar");

                entity.Property(e => e.Mob)
                    .HasMaxLength(255)
                    .HasColumnName("mob");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("testimonials");

                entity.HasCharSet("armscii8")
                    .UseCollation("armscii8_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("comment")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .UseCollation("utf8mb4_0900_ai_ci")
                    .HasCharSet("utf8mb4");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Email, "users_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessToken)
                    .HasColumnType("text")
                    .HasColumnName("access_token");

                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.Area)
                    .HasMaxLength(1000)
                    .HasColumnName("area");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.EmailVerifiedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("email_verified_at");

                entity.Property(e => e.EmirateId).HasColumnName("emirate_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("first_name");

                entity.Property(e => e.FlatNumber)
                    .HasMaxLength(1000)
                    .HasColumnName("flat_number");

                entity.Property(e => e.Floor)
                    .HasMaxLength(1000)
                    .HasColumnName("floor");

                entity.Property(e => e.Gender)
                    .HasColumnType("enum('male','female')")
                    .HasColumnName("gender")
                    .HasDefaultValueSql("'male'");

                entity.Property(e => e.Height)
                    .HasPrecision(8, 2)
                    .HasColumnName("height");

                entity.Property(e => e.Image)
                    .HasMaxLength(1000)
                    .HasColumnName("image");

                entity.Property(e => e.LandLine)
                    .HasMaxLength(191)
                    .HasColumnName("land_line")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastName)
                    .HasMaxLength(191)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("phone_number");

                entity.Property(e => e.RememberToken)
                    .HasMaxLength(100)
                    .HasColumnName("remember_token");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("role")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SecondPhoneNumber)
                    .HasMaxLength(191)
                    .HasColumnName("second_phone_number")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'client'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Weight).HasPrecision(8, 2);
            });

            modelBuilder.Entity<UserCid>(entity =>
            {
                entity.ToTable("user_cids");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cid)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UserDevice>(entity =>
            {
                entity.ToTable("user_device");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.UserId, "user_device_user_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeviceToken)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("device_token");

                entity.Property(e => e.DeviceType)
                    .IsRequired()
                    .HasColumnType("enum('ios','android')")
                    .HasColumnName("device_type")
                    .HasDefaultValueSql("'android'");

                entity.Property(e => e.Notify)
                    .HasMaxLength(1)
                    .HasColumnName("notify")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
