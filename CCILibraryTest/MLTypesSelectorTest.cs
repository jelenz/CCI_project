﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MATFile;
using MLTypes;

namespace CCIUtilitiesUnitTest
{
    [TestClass]
    public class MLTypesSelector
    {
        const string directory = @"../../../CCILibraryTest/Test files";

        [TestMethod]
        public void MLTypesSelectorUnitTest()
        {
            MLVariables mlv;
            string[] testFiles = Directory.GetFiles(directory);
            foreach (string file in testFiles)
                if (Path.GetExtension(file) == "mat" || Path.GetExtension(file) == "set")
                {
                    FileStream f = new FileStream(file, FileMode.Open, FileAccess.Read);
                    Console.WriteLine();
                    Console.WriteLine("******** " + f.Name + " ********");
                    MATFileReader mfr = new MATFileReader(f);
                    mlv = mfr.ReadAllVariables();
                    foreach (KeyValuePair<string, MLType> kvp in mlv)
                    {
                        Console.WriteLine(kvp.Key + " =");
                        if (kvp.Value != null)
                            Console.WriteLine(kvp.Value.ToString());
                    }
                }
            //double init_time = (double)mlv.Select("EEG.event[%].init_time", 5);
            //object s = mlv.Select("EEG.times[%]", 55);
        }
    }
}
