﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game
{
    internal class Gamewin
    {
        public PictureBox m_picture;
        Form1 m_parent;
        public Gamewin(PictureBox picture)
        {
            m_picture = picture;
        }
        public void Win()
        {
            Environment.Exit(0);  
        }
    }
}
