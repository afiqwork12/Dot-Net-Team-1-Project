using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Models
{
    public class BookAPIContext : DbContext
    {
        public BookAPIContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>().HasMany(b => b.BookGenres);
            //modelBuilder.Entity<Genre>().HasMany(g => g.BookGenres);
            modelBuilder.Entity<BookGenre>().HasKey(bg => new { bg.BookId, bg.GenreId });
            modelBuilder.Entity<Book>().HasData(
                new Book() { Id = 1, Title = "Sin Eater", Author = "Megan Campisi", Description = "For the crime of stealing bread, fourteen-year-old May receives a life sentence: she must become a Sin Eater—a shunned woman, brutally marked, whose fate is to hear the final confessions of the dying, eat ritual foods symbolizing their sins as a funeral rite, and thereby shoulder their transgressions to grant their souls access to heaven.\nOrphaned and friendless, apprenticed to an older Sin Eater who cannot speak to her, May must make her way in a dangerous and cruel world she barely understands. When a deer heart appears on the coffin of a royal governess who did not confess to the dreadful sin it represents, the older Sin Eater refuses to eat it. She is taken to prison, tortured, and killed. To avenge her death, May must find out who placed the deer heart on the coffin and why.", Language = "English", Cost = 22.2, Picture = "/images/book1.jpg" },
                new Book() { Id = 2, Title = "Agnes at the End of the World", Author = "Kelly McWilliams", Description = "Agnes loves her home of Red Creek--its quiet, sunny mornings, its dusty roads, and its God. There, she cares tirelessly for her younger siblings and follows the town's strict laws. What she doesn't know is that Red Creek is a cult, controlled by a madman who calls himself a prophet.\nThen Agnes meets Danny, an Outsider boy, and begins to question what is and isn't a sin. Her younger brother, Ezekiel, will die without the insulin she barters for once a month, even though medicine is considered outlawed. Is she a sinner for saving him? Is her sister, Beth, a sinner for dreaming of the world beyond Red Creek?\nAs the Prophet grows more dangerous, Agnes realizes she must escape with Ezekiel and leave everyone else, including Beth, behind. But it isn't safe Outside, either: A viral pandemic is burning through the population at a terrifying rate. As Agnes ventures forth, a mysterious connection grows between her and the Virus. But in a world where faith, miracles, and cruelty have long been indistinguishable, will Agnes be able to choose between saving her family and saving the world?", Language = "English", Cost = 22.2, Picture = "/images/book2.jfif" },
                new Book() { Id = 3, Title = "The Hypocrite World", Author = "Sopia Hill", Description = "Sophia Hill strips from the Daily Magazine are finally available in this deluxe limited collection", Language = "English", Cost = 22.2, Picture = "/images/book3.jpg" },
                new Book() { Id = 4, Title = "Blood & Honey", Author = "Shelby Mahurin", Description = "After narrowly escaping death at the hands of the Dames Blanches, Lou, Reid, Coco, and Ansel are on the run from coven, kingdom, and church—fugitives with nowhere to hide.\nTo elude the scores of witches and throngs of chasseurs at their heels, Lou and Reid need allies. Strong ones. But protection comes at a price, and the group is forced to embark on separate quests to build their forces. As Lou and Reid try to close the widening rift between them, the dastardly Morgane baits them in a lethal game of cat and mouse that threatens to destroy something worth more than any coven.", Language = "English", Cost = 22.2, Picture = "/images/book4.jfif" },
                new Book() { Id = 5, Title = "IT", Author = "Stephen King", Description = "Welcome to Derry, Maine. It’s a small city, a place as hauntingly familiar as your own hometown. Only in Derry the haunting is real.\nThey were seven teenagers when they first stumbled upon the horror. Now they are grown-up men and women who have gone out into the big world to gain success and happiness. But the promise they made twenty-eight years ago calls them reunite in the same place where, as teenagers, they battled an evil creature that preyed on the city’s children. Now, children are being murdered again and their repressed memories of that terrifying summer return as they prepare to once again battle the monster lurking in Derry’s sewers.", Language = "English", Cost = 22.2, Picture = "/images/book5.png" },
                new Book() { Id = 6, Title = "I Know Why the Caged Bird Sings", Author = "Maya Angelou", Description = "Maya Angelou’s debut memoir is a modern American classic beloved worldwide. Her life story is told in the documentary film And Still I Rise, as seen on PBS’s American Masters.\nHere is a book as joyous and painful, as mysterious and memorable, as childhood itself. I Know Why the Caged Bird Sings captures the longing of lonely children, the brute insult of bigotry, and the wonder of words that can make the world right. Maya Angelou’s debut memoir is a modern American classic beloved worldwide.\nSent by their mother to live with their devout, self-sufficient grandmother in a small Southern town, Maya and her brother, Bailey, endure the ache of abandonment and the prejudice of the local “powhitetrash.” At eight years old and back at her mother’s side in St. Louis, Maya is attacked by a man many times her age—and has to live with the consequences for a lifetime. Years later, in San Francisco, Maya learns that love for herself, the kindness of others, her own strong spirit, and the ideas of great authors (“I met and fell in love with William Shakespeare”) will allow her to be free instead of imprisoned.\nPoetic and powerful, I Know Why the Caged Bird Sings will touch hearts and change minds for as long as people read.", Language = "English", Cost = 22.2, Picture = "/images/book6.jfif" },
                new Book() { Id = 7, Title = "In The Company of Ghost", Author = "Andrew Author", Description = "Inspector George Grimchard of Scotland Yard is the only man to have solved a premeditated murder in the last fifty years without resorting to the testimony of the deceased. Moreover is he the grandson of Edgar Grimchard, disgraced founder of the Department of Irregular Souls, a police department that has virtually ridden the British Empire of murder by solving crimes using the testimony of spirits held at séance.\nWhen a body is unearthed in the garden of a Holland Park mansion and the ghost claims to be the man who is now running the Department of Irregular Souls, Grimchard is thrown together with the lazy, indulgent detective Arthur Lyle, himself of the Department. Faced with the fact that the man running the Department is himself an impostor, the mismatched duo soon unearth dark secrets that could shatter the art of spiritualism forever. The Department, it seems, is in league with Nazi spiritualists rescued from Berlin at the end of the war and brought to England. Together, they have been working to refine a technique for giving substance back to ghosts – allowing them to walk and talk without the need for a séance. Ostensibly, this is part of a political move to allow the torture of ghosts – but, for Grimchard, the matter is a simple one: a murder, hidden for thirty years, which must not go unpunished.", Language = "English", Cost = 22.2, Picture = "/images/book7.jpg" },
                new Book() { Id = 8, Title = "Five Tuesdays in Winter", Author = "Lily King", Description = "By the award-winning, New York Times bestselling author of Writers & Lovers, Lily King's first-ever collection of exceptional and innovative short stories.\nTold in the intimate voices of unique and endearing characters of all ages, these tales explore desire and heartache, loss and discovery, moments of jolting violence and the inexorable tug toward love at all costs. A bookseller's unspoken love for his employee rises to the surface, a neglected teenage boy finds much-needed nurturing from an unlikely pair of college students hired to housesit, a girl's loss of innocence at the hands of her employer's son becomes a catalyst for strength and confidence, and a proud nonagenarian rages helplessly in his granddaughter's hospital room. Romantic, hopeful, brutally raw, and unsparingly honest, some even slipping into the surreal, these stories are, above all, about King's enduring subject of love.", Language = "English", Cost = 22.2, Picture = "/images/book8.jpg" },
                new Book() { Id = 9, Title = "Charlotte's Web", Author = "E.B White", Description = "This beloved book by E. B. White, author of Stuart Little and The Trumpet of the Swan, is a classic of children's literature that is \"just about perfect.\" This high-quality paperback features vibrant illustrations colorized by Rosemary Wells!\nSome Pig. Humble. Radiant. These are the words in Charlotte's Web, high up in Zuckerman's barn. Charlotte's spiderweb tells of her feelings for a little pig named Wilbur, who simply wants a friend. They also express the love of a girl named Fern, who saved Wilbur's life when he was born the runt of his litter.\nE. B. White's Newbery Honor Book is a tender novel of friendship, love, life, and death that will continue to be enjoyed by generations to come. This edition contains newly color illustrations by Garth Williams, the acclaimed illustrator of E. B. White's Stuart Little and Laura Ingalls Wilder's Little House series, among many other books.", Language = "English", Cost = 22.2, Picture = "/images/book9.jpg" }
            );
            modelBuilder.Entity<Genre>().HasData(
                new Genre() { Id = 1, Name = "Fiction" },
                new Genre() { Id = 2, Name = "Nonfiction" },
                new Genre() { Id = 3, Name = "Action and adventure" },
                new Genre() { Id = 4, Name = "Alternate history" },
                new Genre() { Id = 5, Name = "Anthology" },
                new Genre() { Id = 6, Name = "Chick lit" },
                new Genre() { Id = 7, Name = "Children's" },
                new Genre() { Id = 8, Name = "Classic" },
                new Genre() { Id = 9, Name = "Comic book" },
                new Genre() { Id = 10, Name = "Coming-of-age" },
                new Genre() { Id = 11, Name = "Crime" },
                new Genre() { Id = 12, Name = "Drama" },
                new Genre() { Id = 13, Name = "Fairytale" },
                new Genre() { Id = 14, Name = "Fantasy" },
                new Genre() { Id = 15, Name = "Graphic novel" },
                new Genre() { Id = 16, Name = "Historical fiction" },
                new Genre() { Id = 17, Name = "Horror" },
                new Genre() { Id = 18, Name = "Mystery" },
                new Genre() { Id = 19, Name = "Paranormal romance" },
                new Genre() { Id = 20, Name = "Picture book" },
                new Genre() { Id = 21, Name = "Poetry" },
                new Genre() { Id = 22, Name = "Political thriller" },
                new Genre() { Id = 23, Name = "Romance" },
                new Genre() { Id = 24, Name = "Satire" },
                new Genre() { Id = 25, Name = "Science fiction" },
                new Genre() { Id = 26, Name = "Short story" },
                new Genre() { Id = 27, Name = "Suspense" },
                new Genre() { Id = 28, Name = "Thriller" },
                new Genre() { Id = 29, Name = "Western" },
                new Genre() { Id = 30, Name = "Young adult" },
                new Genre() { Id = 31, Name = "Art/architecture" },
                new Genre() { Id = 32, Name = "Autobiography" },
                new Genre() { Id = 33, Name = "Biography" },
                new Genre() { Id = 34, Name = "Business/economics" },
                new Genre() { Id = 35, Name = "Crafts/hobbies" },
                new Genre() { Id = 36, Name = "Cookbook" },
                new Genre() { Id = 37, Name = "Diary" },
                new Genre() { Id = 38, Name = "Dictionary" },
                new Genre() { Id = 39, Name = "Encyclopedia" },
                new Genre() { Id = 40, Name = "Guide" },
                new Genre() { Id = 41, Name = "Health/fitness" },
                new Genre() { Id = 42, Name = "History" },
                new Genre() { Id = 43, Name = "Home and garden" },
                new Genre() { Id = 44, Name = "Humor" },
                new Genre() { Id = 45, Name = "Journal" },
                new Genre() { Id = 46, Name = "Math" },
                new Genre() { Id = 47, Name = "Memoir" },
                new Genre() { Id = 48, Name = "Philosophy" },
                new Genre() { Id = 49, Name = "Prayer" },
                new Genre() { Id = 50, Name = "Religion, spirituality, and new age" },
                new Genre() { Id = 51, Name = "Textbook" },
                new Genre() { Id = 52, Name = "True crime" },
                new Genre() { Id = 53, Name = "Review" },
                new Genre() { Id = 54, Name = "Science" },
                new Genre() { Id = 55, Name = "Self help" },
                new Genre() { Id = 56, Name = "Sports and leisure" },
                new Genre() { Id = 57, Name = "Travel" },
                new Genre() { Id = 58, Name = "True crime" }
            );
            modelBuilder.Entity<BookGenre>().HasData(
                new BookGenre() { BookId = 1, GenreId = 1 },
                new BookGenre() { BookId = 2, GenreId = 2 },
                new BookGenre() { BookId = 3, GenreId = 3 },
                new BookGenre() { BookId = 4, GenreId = 4 },
                new BookGenre() { BookId = 5, GenreId = 5 },
                new BookGenre() { BookId = 6, GenreId = 6 },
                new BookGenre() { BookId = 7, GenreId = 7 },
                new BookGenre() { BookId = 8, GenreId = 9 },
                new BookGenre() { BookId = 9, GenreId = 9 }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
