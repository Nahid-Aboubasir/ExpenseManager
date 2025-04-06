﻿namespace Domain.Entities
{
    public class Expense
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public long Amount { get; set; }

        public DateTime Date { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
