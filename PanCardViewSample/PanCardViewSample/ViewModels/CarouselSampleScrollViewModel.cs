﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace PanCardViewSample.ViewModels
{
    public class CarouselSampleScrollViewModel
    {
        public CarouselSampleScrollViewModel()
        {
            Items = new ObservableCollection<object>(Enumerable.Range(1, 1000).Select(i => new { Number = i }).ToArray());
        }

        public ObservableCollection<object> Items { get; }
    }
}