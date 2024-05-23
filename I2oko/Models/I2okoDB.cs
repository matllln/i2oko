﻿using System.Data.Entity;

namespace I2oko.Models
{
    public class I2okoDB : DbContext
    {
        public DbSet<UserModel> User { get; set; }
        public DbSet<ThirdInventoryModel> ThirdInventory { get; set; }
        public DbSet<SocialMediaModel> SocialMedia { get; set; }
        public DbSet<SecondInventoryModel> SecindInventory { get; set; }
        public DbSet<RequestModel> Request { get; set; }
        public DbSet<PostModel> Post { get; set; }
        public DbSet<PetModel> Pet { get; set; }
        public DbSet<NewsModel> News { get; set; }
        public DbSet<IntroductionsModel> Introductions { get; set; }
        public DbSet<FoodSpecifiacationModel> FoodSpecifiacation { get; set; }
        public DbSet<FoodModel> Food { get; set; }
        public DbSet<FollowingsModel> Followings { get; set; }
        public DbSet<FollowersModel> Followers { get; set; }
        public DbSet<FirstInventoryModel> FirstInventory { get; set; }
        public DbSet<DirectModel> Direct { get; set; }
        public DbSet<CommentModel> Comment { get; set; }
        public DbSet<BeautifulTableModel> BeautifulTable { get; set; }
        public DbSet<DeliciousModel> Delicious { get; set; }
        public DbSet<FavoriteModel> Favorite { get; set; }
        public DbSet<RelationFIModel> RelationFI { get; set; }
        public DbSet<RelationPostModel> RelationPost { get; set; }
        public DbSet<RelationNotifModel> RelationNotif { get; set; }
        public DbSet<LikeModel> Like { get; set; }
        public DbSet<CommentLikeModel> CommentLike { get; set; }
        public DbSet<MngUserModel> MngUser { get; set; }
    }
}