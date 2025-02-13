﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tires[] tires;
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine @Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public Cargo @Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public Tires[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
    }
}
