using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace Question_07
{
    class preprocessing
    {

        IplImage srcImage, MaskImage, MaskImage3, srcImage3;
        IplImage ANDOperation, OROperation, NOTOperation, XOROperation, OROperation3;
        IplImage srcImage2, MaskImage2, ADD, ADDW;

        public void LoadOriginalImage(string fname)
        {
            srcImage = Cv.LoadImage("BinaryImage.png", LoadMode.Color);
            Cv.SaveImage("BinaryImageSave.png", srcImage);
        }

        //Mask Image
        public void LoadMaskImage()
        {
            MaskImage = Cv.LoadImage("MaskImage.png", LoadMode.Color);
            Cv.SaveImage("MaskOutputImage.png", MaskImage);
        }

        //AND Operator
        public void ANDOperator()
        {
            ANDOperation = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.And(srcImage, MaskImage, ANDOperation);
            Cv.SaveImage("AND.png", ANDOperation);
        }

        //OR Operator
        public void OROperator()
        {
            OROperation = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Or(srcImage, MaskImage, OROperation);
            Cv.SaveImage("OR.png", OROperation);
        }

        //NOT Operator
        public void NOTOperator()
        {
            NOTOperation = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Not(srcImage, NOTOperation);
            Cv.SaveImage("NOT.png", NOTOperation);
        }

        //XOR Operator
        public void XOROperator()
        {
            XOROperation = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Xor(srcImage, MaskImage, XOROperation);
            Cv.SaveImage("XOR.png", XOROperation);
        }


        /////////// PART B/////////////////

        public void LoadOriginalImage1(string fname)
        {
            srcImage2 = Cv.LoadImage("BinaryImage.png", LoadMode.Color);
            Cv.SaveImage("BinaryImageSave2.png", srcImage2);
        }

        public void LoadMaskImage1()
        {
            MaskImage2 = Cv.LoadImage("MaskImage2.png", LoadMode.Color);
            Cv.SaveImage("MaskOutputImage2.png", MaskImage2);
        }

        //Addition
        public void Addition()
        {
            ADD = Cv.CreateImage(srcImage2.Size, BitDepth.U8, 3);
            Cv.AddWeighted(srcImage2, 0.7, MaskImage2, 0.3, 0, ADD);
            Cv.Add(srcImage2, MaskImage2, ADD);
            Cv.SaveImage("ADD.png", ADD);

        }

        //Addition
        public void AddWeight()
        {
            ADDW = Cv.CreateImage(srcImage2.Size, BitDepth.U8, 3);
            Cv.AddWeighted(srcImage2, 0.7, MaskImage2, 0.3, 0, ADDW);
            Cv.SaveImage("ADDweight.png", ADDW);

        }


        ///////// PART C/////

        public void LoadOriginalImage3(string fname)
        {
            srcImage3 = Cv.LoadImage("7a.png", LoadMode.Color);
            Cv.SaveImage("7aOutput.png", srcImage3);
        }

        public void LoadMaskImage3()
        {
            MaskImage3 = Cv.LoadImage("MaskImage3.png", LoadMode.Color);
            Cv.SaveImage("MaskOutputImage3.png", MaskImage3);
        }

        public void OROperator3()
        {
            OROperation3 = Cv.CreateImage(srcImage3.Size, BitDepth.U8, 3);
            Cv.Or(srcImage3, MaskImage3, OROperation3);
            Cv.SaveImage("LOGO.png", OROperation3);
        }
    }
}