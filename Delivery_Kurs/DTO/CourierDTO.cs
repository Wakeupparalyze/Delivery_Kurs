﻿namespace DeliveryKursApi.DTO
{
    public class CourierDTO
    {
        public int Id { get; set; }

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Lastname { get; set; } = null!;
    }
}
