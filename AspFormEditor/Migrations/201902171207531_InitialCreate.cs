// <copyright file="201902171207531_InitialCreate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// InitialCreate class.
    /// </summary>
    public partial class InitialCreate : DbMigration
    {
        /// <summary>
        /// Up method.
        /// </summary>
        public override void Up()
        {
            this.CreateTable(
                "dbo.Fields",
                c => new
                    {
                        FieldId = c.Int(nullable: false, identity: true),
                        FieldTitle = c.String(nullable: false, maxLength: 20),
                        Type = c.Int(nullable: false),
                        Question = c.String(maxLength: 150),
                        Required = c.Boolean(nullable: false),
                        Form_FormId = c.Int(),
                    })
                .PrimaryKey(t => t.FieldId)
                .ForeignKey("dbo.Forms", t => t.Form_FormId)
                .Index(t => t.Form_FormId);

            this.CreateTable(
                "dbo.Forms",
                c => new
                    {
                        FormId = c.Int(nullable: false, identity: true),
                        FormTitle = c.String(nullable: false, maxLength: 20),
                        Description = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.FormId);
        }

        /// <summary>
        /// Down method.
        /// </summary>
        public override void Down()
        {
            this.DropForeignKey("dbo.Fields", "Form_FormId", "dbo.Forms");
            this.DropIndex("dbo.Fields", new[] { "Form_FormId" });
            this.DropTable("dbo.Forms");
            this.DropTable("dbo.Fields");
        }
    }
}
