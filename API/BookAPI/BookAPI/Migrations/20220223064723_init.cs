using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookGenres_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Cost", "Description", "Language", "Picture", "Title" },
                values: new object[,]
                {
                    { 1, "Megan Campisi", 22.199999999999999, @"For the crime of stealing bread, fourteen-year-old May receives a life sentence: she must become a Sin Eater—a shunned woman, brutally marked, whose fate is to hear the final confessions of the dying, eat ritual foods symbolizing their sins as a funeral rite, and thereby shoulder their transgressions to grant their souls access to heaven.
                Orphaned and friendless, apprenticed to an older Sin Eater who cannot speak to her, May must make her way in a dangerous and cruel world she barely understands. When a deer heart appears on the coffin of a royal governess who did not confess to the dreadful sin it represents, the older Sin Eater refuses to eat it. She is taken to prison, tortured, and killed. To avenge her death, May must find out who placed the deer heart on the coffin and why.", "English", "/images/book1.jpg", "Sin Eater" },
                    { 2, "Kelly McWilliams", 22.199999999999999, @"Agnes loves her home of Red Creek--its quiet, sunny mornings, its dusty roads, and its God. There, she cares tirelessly for her younger siblings and follows the town's strict laws. What she doesn't know is that Red Creek is a cult, controlled by a madman who calls himself a prophet.
                Then Agnes meets Danny, an Outsider boy, and begins to question what is and isn't a sin. Her younger brother, Ezekiel, will die without the insulin she barters for once a month, even though medicine is considered outlawed. Is she a sinner for saving him? Is her sister, Beth, a sinner for dreaming of the world beyond Red Creek?
                As the Prophet grows more dangerous, Agnes realizes she must escape with Ezekiel and leave everyone else, including Beth, behind. But it isn't safe Outside, either: A viral pandemic is burning through the population at a terrifying rate. As Agnes ventures forth, a mysterious connection grows between her and the Virus. But in a world where faith, miracles, and cruelty have long been indistinguishable, will Agnes be able to choose between saving her family and saving the world?", "English", "/images/book2.jfif", "Agnes at the End of the World" },
                    { 3, "Sopia Hill", 22.199999999999999, "Sophia Hill strips from the Daily Magazine are finally available in this deluxe limited collection", "English", "/images/book3.jpg", "The Hypocrite World" },
                    { 4, "Shelby Mahurin", 22.199999999999999, @"After narrowly escaping death at the hands of the Dames Blanches, Lou, Reid, Coco, and Ansel are on the run from coven, kingdom, and church—fugitives with nowhere to hide.
                To elude the scores of witches and throngs of chasseurs at their heels, Lou and Reid need allies. Strong ones. But protection comes at a price, and the group is forced to embark on separate quests to build their forces. As Lou and Reid try to close the widening rift between them, the dastardly Morgane baits them in a lethal game of cat and mouse that threatens to destroy something worth more than any coven.", "English", "/images/book4.jfif", "Blood & Honey" },
                    { 5, "Stephen King", 22.199999999999999, @"Welcome to Derry, Maine. It’s a small city, a place as hauntingly familiar as your own hometown. Only in Derry the haunting is real.
                They were seven teenagers when they first stumbled upon the horror. Now they are grown-up men and women who have gone out into the big world to gain success and happiness. But the promise they made twenty-eight years ago calls them reunite in the same place where, as teenagers, they battled an evil creature that preyed on the city’s children. Now, children are being murdered again and their repressed memories of that terrifying summer return as they prepare to once again battle the monster lurking in Derry’s sewers.", "English", "/images/book5.png", "IT" },
                    { 6, "Maya Angelou", 22.199999999999999, @"Maya Angelou’s debut memoir is a modern American classic beloved worldwide. Her life story is told in the documentary film And Still I Rise, as seen on PBS’s American Masters.
                Here is a book as joyous and painful, as mysterious and memorable, as childhood itself. I Know Why the Caged Bird Sings captures the longing of lonely children, the brute insult of bigotry, and the wonder of words that can make the world right. Maya Angelou’s debut memoir is a modern American classic beloved worldwide.
                Sent by their mother to live with their devout, self-sufficient grandmother in a small Southern town, Maya and her brother, Bailey, endure the ache of abandonment and the prejudice of the local “powhitetrash.” At eight years old and back at her mother’s side in St. Louis, Maya is attacked by a man many times her age—and has to live with the consequences for a lifetime. Years later, in San Francisco, Maya learns that love for herself, the kindness of others, her own strong spirit, and the ideas of great authors (“I met and fell in love with William Shakespeare”) will allow her to be free instead of imprisoned.
                Poetic and powerful, I Know Why the Caged Bird Sings will touch hearts and change minds for as long as people read.", "English", "/images/book6.jfif", "I Know Why the Caged Bird Sings" },
                    { 7, "Andrew Author", 22.199999999999999, @"Inspector George Grimchard of Scotland Yard is the only man to have solved a premeditated murder in the last fifty years without resorting to the testimony of the deceased. Moreover is he the grandson of Edgar Grimchard, disgraced founder of the Department of Irregular Souls, a police department that has virtually ridden the British Empire of murder by solving crimes using the testimony of spirits held at séance.
                When a body is unearthed in the garden of a Holland Park mansion and the ghost claims to be the man who is now running the Department of Irregular Souls, Grimchard is thrown together with the lazy, indulgent detective Arthur Lyle, himself of the Department. Faced with the fact that the man running the Department is himself an impostor, the mismatched duo soon unearth dark secrets that could shatter the art of spiritualism forever. The Department, it seems, is in league with Nazi spiritualists rescued from Berlin at the end of the war and brought to England. Together, they have been working to refine a technique for giving substance back to ghosts – allowing them to walk and talk without the need for a séance. Ostensibly, this is part of a political move to allow the torture of ghosts – but, for Grimchard, the matter is a simple one: a murder, hidden for thirty years, which must not go unpunished.", "English", "/images/book7.jpg", "In The Company of Ghost" },
                    { 8, "Lily King", 22.199999999999999, @"By the award-winning, New York Times bestselling author of Writers & Lovers, Lily King's first-ever collection of exceptional and innovative short stories.
                Told in the intimate voices of unique and endearing characters of all ages, these tales explore desire and heartache, loss and discovery, moments of jolting violence and the inexorable tug toward love at all costs. A bookseller's unspoken love for his employee rises to the surface, a neglected teenage boy finds much-needed nurturing from an unlikely pair of college students hired to housesit, a girl's loss of innocence at the hands of her employer's son becomes a catalyst for strength and confidence, and a proud nonagenarian rages helplessly in his granddaughter's hospital room. Romantic, hopeful, brutally raw, and unsparingly honest, some even slipping into the surreal, these stories are, above all, about King's enduring subject of love.", "English", "/images/book8.jpg", "Five Tuesdays in Winter" },
                    { 9, "E.B White", 22.199999999999999, @"This beloved book by E. B. White, author of Stuart Little and The Trumpet of the Swan, is a classic of children's literature that is ""just about perfect."" This high-quality paperback features vibrant illustrations colorized by Rosemary Wells!
                Some Pig. Humble. Radiant. These are the words in Charlotte's Web, high up in Zuckerman's barn. Charlotte's spiderweb tells of her feelings for a little pig named Wilbur, who simply wants a friend. They also express the love of a girl named Fern, who saved Wilbur's life when he was born the runt of his litter.
                E. B. White's Newbery Honor Book is a tender novel of friendship, love, life, and death that will continue to be enjoyed by generations to come. This edition contains newly color illustrations by Garth Williams, the acclaimed illustrator of E. B. White's Stuart Little and Laura Ingalls Wilder's Little House series, among many other books.", "English", "/images/book9.jpg", "Charlotte's Web" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 41, "Health/fitness" },
                    { 40, "Guide" },
                    { 39, "Encyclopedia" },
                    { 38, "Dictionary" },
                    { 37, "Diary" },
                    { 32, "Autobiography" },
                    { 35, "Crafts/hobbies" },
                    { 34, "Business/economics" },
                    { 33, "Biography" },
                    { 42, "History" },
                    { 31, "Art/architecture" },
                    { 36, "Cookbook" },
                    { 43, "Home and garden" },
                    { 47, "Memoir" },
                    { 45, "Journal" },
                    { 46, "Math" },
                    { 30, "Young adult" },
                    { 48, "Philosophy" },
                    { 49, "Prayer" },
                    { 50, "Religion, spirituality, and new age" },
                    { 51, "Textbook" },
                    { 52, "True crime" },
                    { 53, "Review" },
                    { 54, "Science" },
                    { 55, "Self help" },
                    { 56, "Sports and leisure" },
                    { 44, "Humor" },
                    { 29, "Western" },
                    { 25, "Science fiction" },
                    { 27, "Suspense" },
                    { 1, "Fiction" },
                    { 2, "Nonfiction" },
                    { 3, "Action and adventure" },
                    { 4, "Alternate history" },
                    { 5, "Anthology" },
                    { 6, "Chick lit" },
                    { 7, "Children's" },
                    { 8, "Classic" },
                    { 9, "Comic book" },
                    { 10, "Coming-of-age" },
                    { 11, "Crime" },
                    { 12, "Drama" },
                    { 28, "Thriller" },
                    { 13, "Fairytale" },
                    { 15, "Graphic novel" },
                    { 16, "Historical fiction" },
                    { 17, "Horror" },
                    { 18, "Mystery" },
                    { 19, "Paranormal romance" },
                    { 20, "Picture book" },
                    { 21, "Poetry" },
                    { 22, "Political thriller" },
                    { 23, "Romance" },
                    { 24, "Satire" },
                    { 57, "Travel" },
                    { 26, "Short story" },
                    { 14, "Fantasy" },
                    { 58, "True crime" }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "Id", "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 9 },
                    { 9, 9, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_BookId",
                table: "BookGenres",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenreId",
                table: "BookGenres",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
