﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsPresentation;

namespace Lab3
{
    public abstract class CMapObject
    {
        private string title;
        private DateTime date;

        public CMapObject(string title)
        {
            this.title = title;
            date = DateTime.Now;
        }

        public string getTitle()
        {
            return title;
        }

        public DateTime getCriationDate()
        {
            return date;
        }

        public abstract double getDistance(PointLatLng point);

        public abstract PointLatLng getFocus();

        public abstract GMapMarker getMarker();
    }
}
