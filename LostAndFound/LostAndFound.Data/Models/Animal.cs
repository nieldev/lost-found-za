﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Data.BaseModels;
using LostAndFound.Data.Models.Lookups;
using LostAndFound.Framework.Enums;

namespace LostAndFound.Data.Models
{
    public class Animal:BaseModel
    {

        public string Description { get; set; }
        public AnimalColor PrimaryColor {get;set;}
        public List<AnimalColor> OtherColors { get; set; }
        public Gender Gender { get; set; }
        public CoatType CoatType { get; set; }
        public CoatLength CoatLength { get; set; }
        public Colorpattern Colorpattern { get; set; }
        public EyeType EyeType { get; set; }
        public EarType EarType { get; set; }
        public TailType TailType { get; set; }
        public SizeClassification SizeClassification { get; set; }
        public BodyMassClassification BodyMassClassification { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
