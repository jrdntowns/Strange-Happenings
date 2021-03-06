﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Strange_Happenings.Models
{
    public class DataInitialiser : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {

            //seed data for users
            User user1 = new User();
            user1.UserID = 1;
            user1.UserName = "cckraken";
            user1.UserFirstName = "Daniel";
            user1.UserLastName = "Barrett";
            user1.Speciality = "eSports";   
            context.User.Add(user1);

            User user2 = new User();
            user2.UserID = 2;
            user2.UserName = "carlincarlin";
            user2.UserFirstName = "Matt";
            user2.UserLastName = "Carlin";
            user2.Speciality = "Weed";
            context.User.Add(user2);

            User user3 = new User();
            user3.UserID = 3;
            user3.UserName = "TommyJ";
            user3.UserFirstName = "Tom";
            user3.UserLastName = "Jones";
            user3.Speciality = "Music";
            context.User.Add(user3);

            User user4 = new User();
            user4.UserID = 4;
            user4.UserName = "TMAY";
            user4.UserFirstName = "Theresa";
            user4.UserLastName = "May";
            context.User.Add(user4);

            User user5 = new User();
            user5.UserID = 5;
            user5.UserName = "Big Brown";
            user5.UserFirstName = "Gordon";
            user5.UserLastName = "Brown";

            User user6 = new User();
            user6.UserID = 6;
            user6.UserName = "Emperor Palpamemes";
            user6.UserFirstName = "Emperor";
            user6.UserLastName = "Palpatene";

            //seed data for articles
            Article article1 = new Article();
            article1.ArticleID = 1;
            article1.ArticleName = "Tottenham vs Chelsea";
            article1.ArticleDescription = "FA cup semifinal. Who wins?";
            article1.UserID = 1;
            article1.GenreID = 1;     
            context.Article.Add(article1);

            //seed data for articles
            Article article2 = new Article();
            article2.ArticleID = 2;
            article2.ArticleName = "Too much salt?";
            article2.ArticleDescription = "How much salt is too much?";
            article2.UserID = 2;
            article2.GenreID = 2;
            context.Article.Add(article2);

            //seed data for articles
            Article article3 = new Article();
            article3.ArticleID = 3;
            article3.ArticleName = "Ebola crisis";
            article3.ArticleDescription = "What can we do to help?";
            article3.UserID = 3;
            article3.GenreID = 3;
            context.Article.Add(article3);

            Article article4 = new Article();
            article4.ArticleID = 4;
            article4.ArticleName = "Favourite programming language?";
            article4.ArticleDescription = "What's everyones favourite programming language? Mine is C#. Comment your favourites and why!";
            article4.UserID = 4;
            article4.GenreID = 4;
            context.Article.Add(article4);

            //seed data for reviews
            Review Review1 = new Review();
            Review1.ReviewID = 4;
            Review1.AuthorName = "Daniel Barrett";
            Review1.ReviewDescription = "Excellent game. Chelsea got lucky though.";
            Review1.ArticleID = 1;
            context.Review.Add(Review1);

            Review Review2 = new Review();
            Review2.ReviewID = 5;
            Review2.AuthorName = "Matt Carlin";
            Review2.ReviewDescription = "I don't like any salt at all on my food.";
            Review2.ArticleID = 2;
            context.Review.Add(Review2);

            Review Review3 = new Review();
            Review3.ReviewID = 6;
            Review3.AuthorName = "Tom jones";
            Review3.ReviewDescription = "Just donate money, I suppose? Unless you're flying to get training and fly out over there.";
            Review3.ArticleID = 3;
            context.Review.Add(Review3);

            Review Review4 = new Review();
            Review4.ReviewID = 7;
            Review4.AuthorName = "Gordon Brown";
            Review4.ReviewDescription = "HTMl is mine. It's so robust since becoming HTML5. I remember the days when I used HTML script. What a pain in the ass that was.";
            Review4.ArticleID = 4;
            context.Review.Add(Review4);

            //seed data for genres
            Genre Genre1 = new Genre();
            Genre1.GenreID = 6;
            Genre1.GenreName = "Football";
            context.Genre.Add(Genre1);

            //seed data for genres
            Genre Genre2 = new Genre();
            Genre2.GenreID = 7;
            Genre2.GenreName = "Cooking";
            context.Genre.Add(Genre2);

            //seed data for genres
            Genre Genre3 = new Genre();
            Genre3.GenreID = 8;
            Genre3.GenreName = "World events";
            context.Genre.Add(Genre3);

            Genre Genre4 = new Genre();
            Genre4.GenreID = 9;
            Genre4.GenreName = "Programming";
            context.Genre.Add(Genre4);

            base.Seed(context);
            context.SaveChanges();



        }
    }
}