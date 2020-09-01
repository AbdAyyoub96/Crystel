namespace DataAccsess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Department_id = c.Int(nullable: false),
                        Project_Name_id = c.Int(nullable: false),
                        Job_Title_id = c.Int(nullable: false),
                        National_id = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Gender = c.Int(nullable: false),
                        CompanyEmail = c.String(),
                        Password = c.String(),
                        skils_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_id, cascadeDelete: true)
                .ForeignKey("dbo.Job_Title", t => t.Job_Title_id, cascadeDelete: true)
                .ForeignKey("dbo.ProjectNames", t => t.Project_Name_id, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.skils_id, cascadeDelete: true)
                .Index(t => t.Department_id)
                .Index(t => t.Project_Name_id)
                .Index(t => t.Job_Title_id)
                .Index(t => t.skils_id);
            
            CreateTable(
                "dbo.Job_Title",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        projectName_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectNames", t => t.projectName_id, cascadeDelete: false)
                .Index(t => t.projectName_id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ScheduleDate = c.DateTime(nullable: false),
                        Work_place_id = c.Int(nullable: false),
                        Shift_start = c.String(),
                        Shift_End = c.String(),
                        totalHour = c.String(),
                        Employee_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_id, cascadeDelete: true)
                .ForeignKey("dbo.WorkPlaces", t => t.Work_place_id, cascadeDelete: true)
                .Index(t => t.Work_place_id)
                .Index(t => t.Employee_id);
            
            CreateTable(
                "dbo.WorkPlaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "skils_id", "dbo.Skills");
            DropForeignKey("dbo.Schedules", "Work_place_id", "dbo.WorkPlaces");
            DropForeignKey("dbo.Schedules", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Project_Name_id", "dbo.ProjectNames");
            DropForeignKey("dbo.Skills", "projectName_id", "dbo.ProjectNames");
            DropForeignKey("dbo.Employees", "Job_Title_id", "dbo.Job_Title");
            DropForeignKey("dbo.Employees", "Department_id", "dbo.Departments");
            DropIndex("dbo.Schedules", new[] { "Employee_id" });
            DropIndex("dbo.Schedules", new[] { "Work_place_id" });
            DropIndex("dbo.Skills", new[] { "projectName_id" });
            DropIndex("dbo.Employees", new[] { "skils_id" });
            DropIndex("dbo.Employees", new[] { "Job_Title_id" });
            DropIndex("dbo.Employees", new[] { "Project_Name_id" });
            DropIndex("dbo.Employees", new[] { "Department_id" });
            DropTable("dbo.WorkPlaces");
            DropTable("dbo.Schedules");
            DropTable("dbo.Skills");
            DropTable("dbo.ProjectNames");
            DropTable("dbo.Job_Title");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
