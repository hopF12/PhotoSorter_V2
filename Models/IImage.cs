﻿namespace Models
{
    public interface IImage
    {
        string ImageName { get; set; }
        string ImagePath { get; set; }
        float Rotation { get; set; }
    }
}