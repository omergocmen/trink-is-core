using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Candidates_CandidateId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_JobAnnouncements_JobAnnouncementId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobAnnouncements_Categories_CategoryId",
                table: "JobAnnouncements");

            migrationBuilder.DropForeignKey(
                name: "FK_JobAnnouncements_Employers_EmployerId",
                table: "JobAnnouncements");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Candidates_CandidateId",
                table: "Applications",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_JobAnnouncements_JobAnnouncementId",
                table: "Applications",
                column: "JobAnnouncementId",
                principalTable: "JobAnnouncements",
                principalColumn: "JobAnnouncementId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobAnnouncements_Categories_CategoryId",
                table: "JobAnnouncements",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobAnnouncements_Employers_EmployerId",
                table: "JobAnnouncements",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Candidates_CandidateId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_JobAnnouncements_JobAnnouncementId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobAnnouncements_Categories_CategoryId",
                table: "JobAnnouncements");

            migrationBuilder.DropForeignKey(
                name: "FK_JobAnnouncements_Employers_EmployerId",
                table: "JobAnnouncements");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Candidates_CandidateId",
                table: "Applications",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "CandidateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_JobAnnouncements_JobAnnouncementId",
                table: "Applications",
                column: "JobAnnouncementId",
                principalTable: "JobAnnouncements",
                principalColumn: "JobAnnouncementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobAnnouncements_Categories_CategoryId",
                table: "JobAnnouncements",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobAnnouncements_Employers_EmployerId",
                table: "JobAnnouncements",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
