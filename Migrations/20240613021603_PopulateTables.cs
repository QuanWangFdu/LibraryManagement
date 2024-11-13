using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Migrations
{
    /// <inheritdoc />
    public partial class PopulateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling" },
                    { 2, "George R.R. Martin" },
                    { 3, "J.R.R. Tolkien" },
                    { 4, "Agatha Christie" },
                    { 5, "Stephen King" },
                    { 6, "Mark Twain" },
                    { 7, "Jane Austen" },
                    { 8, "Charles Dickens" },
                    { 9, "Ernest Hemingway" },
                    { 10, "F. Scott Fitzgerald" },
                    { 11, "Leo Tolstoy" },
                    { 12, "Fyodor Dostoevsky" },
                    { 13, "Gabriel Garcia Marquez" },
                    { 14, "Haruki Murakami" },
                    { 15, "James Patterson" },
                    { 16, "John Grisham" },
                    { 17, "Dan Brown" },
                    { 18, "Paulo Coelho" },
                    { 19, "Arthur Conan Doyle" },
                    { 20, "Roald Dahl" }
                }
            );

            // Populate Customers table
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Name" },
                values: new object[,]
                {
                    { 1, "Alice Johnson" },
                    { 2, "Bob Smith" },
                    { 3, "Carol Taylor" },
                    { 4, "David Brown" },
                    { 5, "Emma Wilson" },
                    { 6, "Frank Thomas" },
                    { 7, "Grace Lewis" },
                    { 8, "Henry Harris" },
                    { 9, "Ivy Walker" },
                    { 10, "Jack Hall" },
                    { 11, "Karen Allen" },
                    { 12, "Larry Young" },
                    { 13, "Mary King" },
                    { 14, "Nancy Wright" },
                    { 15, "Oscar Lopez" },
                    { 16, "Paul Hill" },
                    { 17, "Queen Scott" },
                    { 18, "Robert Green" },
                    { 19, "Susan Adams" },
                    { 20, "Tom Baker" }
                }
            );

            // Populate LibraryBranches table
            migrationBuilder.InsertData(
                table: "LibraryBranches",
                columns: new[] { "LibraryBranchId", "BranchName" },
                values: new object[,]
                {
                    { 1, "Central Library" },
                    { 2, "Westside Branch" },
                    { 3, "Eastside Branch" },
                    { 4, "Northside Branch" },
                    { 5, "Southside Branch" },
                    { 6, "Downtown Branch" },
                    { 7, "Uptown Branch" },
                    { 8, "Suburban Branch" },
                    { 9, "Riverside Branch" },
                    { 10, "Hilltop Branch" },
                    { 11, "Lakeside Branch" },
                    { 12, "Greenfield Branch" },
                    { 13, "Meadowbrook Branch" },
                    { 14, "Oakwood Branch" },
                    { 15, "Pinehurst Branch" },
                    { 16, "Maplewood Branch" },
                    { 17, "Sunnyside Branch" },
                    { 18, "Cedar Park Branch" },
                    { 19, "Elmwood Branch" },
                    { 20, "Birchwood Branch" }
                }
            );

            // Populate Books table
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Title", "AuthorId", "LibraryBranchId" },
                values: new object[,]
                {
                    { 1, "Harry Potter and the Philosopher's Stone", 1, 1 },
                    { 2, "A Game of Thrones", 2, 1 },
                    { 3, "The Hobbit", 3, 1 },
                    { 4, "Murder on the Orient Express", 4, 1 },
                    { 5, "The Shining", 5, 1 },
                    { 6, "Adventures of Huckleberry Finn", 6, 2 },
                    { 7, "Pride and Prejudice", 7, 2 },
                    { 8, "A Tale of Two Cities", 8, 2 },
                    { 9, "The Old Man and the Sea", 9, 2 },
                    { 10, "The Great Gatsby", 10, 2 },
                    { 11, "War and Peace", 11, 3 },
                    { 12, "Crime and Punishment", 12, 3 },
                    { 13, "One Hundred Years of Solitude", 13, 3 },
                    { 14, "Norwegian Wood", 14, 3 },
                    { 15, "Along Came a Spider", 15, 3 },
                    { 16, "The Firm", 16, 4 },
                    { 17, "The Da Vinci Code", 17, 4 },
                    { 18, "The Alchemist", 18, 4 },
                    { 19, "The Adventures of Sherlock Holmes", 19, 4 },
                    { 20, "Charlie and the Chocolate Factory", 20, 4 }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
