using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LCWebApi.Server.MealsModels
{
    public partial class lowcalories_mealsContext : DbContext
    {
        public lowcalories_mealsContext()
        {
        }

        public lowcalories_mealsContext(DbContextOptions<lowcalories_mealsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomPlanDetail> CustomPlanDetails { get; set; }
        public virtual DbSet<CustomPlanPrice> CustomPlanPrices { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<DeliveryFourtyDay> DeliveryFourtyDays { get; set; }
        public virtual DbSet<DeliveryTwentyDay> DeliveryTwentyDays { get; set; }
        public virtual DbSet<FourtyDayMeal> FourtyDayMeals { get; set; }
        public virtual DbSet<GiftCode> GiftCodes { get; set; }
        public virtual DbSet<GiftCodePlan> GiftCodePlans { get; set; }
        public virtual DbSet<GiftCodeProgram> GiftCodePrograms { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<PlanOption> PlanOptions { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Sheet1> Sheet1s { get; set; }
        public virtual DbSet<Side> Sides { get; set; }
        public virtual DbSet<SubscriptionDay> SubscriptionDays { get; set; }
        public virtual DbSet<SubscriptionDayDetail> SubscriptionDayDetails { get; set; }
        public virtual DbSet<TwentyDayMeal> TwentyDayMeals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;database=lowcalories_meals;user=root;persist security info=False;connect timeout=300", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            modelBuilder.Entity<CustomPlanDetail>(entity =>
            {
                entity.ToTable("custom_plan_details");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.MaxDays).HasColumnName("max_days");

                entity.Property(e => e.MaxMeal).HasColumnName("max_meal");

                entity.Property(e => e.MaxSnack).HasColumnName("max_snack");

                entity.Property(e => e.MinDays).HasColumnName("min_days");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Shotcutname)
                    .HasMaxLength(11)
                    .HasColumnName("shotcutname");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.CustomPlanDetails)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("custom_plan_details_ibfk_1");
            });

            modelBuilder.Entity<CustomPlanPrice>(entity =>
            {
                entity.ToTable("custom_plan_prices");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("custom_plan_prices_ibfk_1");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("days");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

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
            });

            modelBuilder.Entity<DeliveryFourtyDay>(entity =>
            {
                entity.ToTable("delivery_fourty_days");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("date");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<DeliveryTwentyDay>(entity =>
            {
                entity.ToTable("delivery_twenty_days");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("date");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<FourtyDayMeal>(entity =>
            {
                entity.ToTable("fourty_day_meals");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.DayId, "day_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.MealId).HasColumnName("meal_id");
            });

            modelBuilder.Entity<GiftCode>(entity =>
            {
                entity.ToTable("gift_codes");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("code");

                entity.Property(e => e.ExpiredAt)
                    .HasMaxLength(6)
                    .HasColumnName("expired_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Gender)
                    .HasColumnType("enum('male','female')")
                    .HasColumnName("gender");

                entity.Property(e => e.NoOfUse)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("no_of_use")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Percentage)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("percentage");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("enum('active','notActive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");
            });

            modelBuilder.Entity<GiftCodePlan>(entity =>
            {
                entity.ToTable("gift_code_plans");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.GiftCodeProgramId, "gift_code_program_id");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GiftCodeProgramId).HasColumnName("gift_code_program_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");
            });

            modelBuilder.Entity<GiftCodeProgram>(entity =>
            {
                entity.ToTable("gift_code_programs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.CodeId, "code_id");

                entity.HasIndex(e => e.ProgramId, "program_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeId).HasColumnName("code_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.HasOne(d => d.Code)
                    .WithMany(p => p.GiftCodePrograms)
                    .HasForeignKey(d => d.CodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gift_code_programs_ibfk_1");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.GiftCodePrograms)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gift_code_programs_ibfk_2");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.ToTable("meals");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryMealId).HasColumnName("category_meal_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionAr)
                    .HasMaxLength(1000)
                    .HasColumnName("description_ar");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Level)
                    .HasMaxLength(11)
                    .HasColumnName("level");

                entity.Property(e => e.MaxMeal)
                    .HasMaxLength(11)
                    .HasColumnName("max_meal");

                entity.Property(e => e.MaxSide)
                    .HasMaxLength(11)
                    .HasColumnName("max_side");

                entity.Property(e => e.MealUnit)
                    .HasMaxLength(11)
                    .HasColumnName("meal_unit");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .HasColumnName("name");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(1000)
                    .HasColumnName("name_ar");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.SideUnit)
                    .HasMaxLength(11)
                    .HasColumnName("side_unit");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('Meal 1','Meal 2','Meal 3','Meal 4','Meal 5','Meal 6','Snack 1','Snack 2')")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("plans");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ProgramId, "program_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(255)
                    .HasColumnName("name_ar");

                entity.Property(e => e.NoMeals)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("no_meals");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plans_ibfk_1");
            });

            modelBuilder.Entity<PlanOption>(entity =>
            {
                entity.ToTable("plan_options");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.PlanId, "plan_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NoDays)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("no_days");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("price");

                entity.Property(e => e.ShortcutName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shortcut_name");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanOptions)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_options_ibfk_1");
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.ToTable("programs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnType("enum('LC','CH')")
                    .HasColumnName("company")
                    .HasDefaultValueSql("'LC'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionAr)
                    .HasMaxLength(255)
                    .HasColumnName("description_ar");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.MaxMeals)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("max_meals");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(255)
                    .HasColumnName("name_ar");

                entity.Property(e => e.NoSnacks).HasColumnName("no_snacks");

                entity.Property(e => e.OrderNumber).HasColumnName("order_number");

                entity.Property(e => e.ShortcutName)
                    .HasColumnType("enum('DTX','GW','LW','KT','LACTO','OVO','PES','VEG')")
                    .HasColumnName("shortcut_name");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("enum('Normal','Custom')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'Normal'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sheet1");

                entity.Property(e => e.B).HasMaxLength(13);

                entity.Property(e => e.C).HasMaxLength(6);

                entity.Property(e => e.F).HasMaxLength(7);

                entity.Property(e => e.G).HasMaxLength(4);
            });

            modelBuilder.Entity<Side>(entity =>
            {
                entity.ToTable("sides");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.MealId, "meal_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionAr)
                    .HasMaxLength(255)
                    .HasColumnName("description_ar");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NameAr)
                    .HasMaxLength(255)
                    .HasColumnName("name_ar");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.Sides)
                    .HasForeignKey(d => d.MealId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sides_ibfk_1");
            });

            modelBuilder.Entity<SubscriptionDay>(entity =>
            {
                entity.ToTable("subscription_days");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

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

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("enum('pending','delivered','not_delivered')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'pending'");

                entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");

                entity.Property(e => e.Updated)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("updated")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<SubscriptionDayDetail>(entity =>
            {
                entity.ToTable("subscription_day_details");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.MaxMain)
                    .HasMaxLength(11)
                    .HasColumnName("max_main");

                entity.Property(e => e.MaxSide)
                    .HasMaxLength(11)
                    .HasColumnName("max_side");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.MealName)
                    .HasMaxLength(255)
                    .HasColumnName("meal_name");

                entity.Property(e => e.MealUnit)
                    .HasColumnType("enum('GM','PCS','NONE')")
                    .HasColumnName("meal_unit")
                    .HasDefaultValueSql("'NONE'")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SideUnit)
                    .HasColumnType("enum('GM','PCS','NONE')")
                    .HasColumnName("side_unit");

                entity.Property(e => e.SnackName)
                    .HasMaxLength(255)
                    .HasColumnName("snack_name");

                entity.Property(e => e.SubscriptionDayId).HasColumnName("subscription_day_id");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('Meal','Snack')")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(6)")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<TwentyDayMeal>(entity =>
            {
                entity.ToTable("twenty_day_meals");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.MealId).HasColumnName("meal_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
