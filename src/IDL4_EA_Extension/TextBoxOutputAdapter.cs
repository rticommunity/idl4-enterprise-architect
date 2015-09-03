/*********************************************************************************************
(c) 2005-2013 Copyright, Real-Time Innovations, Inc.  All rights reserved.    	                             
RTI grants Licensee a license to use, modify, compile, and create derivative works 
of the Software.  Licensee has the right to distribute object form only for use with RTI 
products.  The Software is provided “as is”, with no warranty of any type, including 
any warranty for fitness for any purpose. RTI is under no obligation to maintain or 
support the Software.  RTI shall not be liable for any incidental or consequential 
damages arising out of the use or inability to use the software.
**********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDL4_EA_Extension
{
    class TextBoxOutputAdapter : TextOutputInterface
    {
        private TextBox _textBox = null;

        public TextBoxOutputAdapter(TextBox textBox)
        {
            _textBox = textBox;
        }
        public String Indent(int depth)
        {
            return "".PadLeft(4 * depth);
        }

        public void OutputText(int depth, String text)
        {
            _textBox.AppendText(Indent(depth) + text);
        }

        public void OutputText(String text)
        {
            _textBox.AppendText(text);
        }

        public void OutputTextLine(int depth, String text)
        {
            _textBox.AppendText(Indent(depth) + text + Environment.NewLine);
        }

        public void OutputTextLine(String text)
        {
            _textBox.AppendText(text + Environment.NewLine);
        }

        public void OutputTextLine()
        {
            _textBox.AppendText(Environment.NewLine);
        }

        public void Clear()
        {
            _textBox.Clear();
        }

        public void SaveToFile(String filePath, String[] preambleLines)
        {
            //System.IO.File.WriteAllText(filePath, _textBox.Text);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
            {
                foreach (String line in preambleLines)
                {
                    file.WriteLine(line);
                }

                file.Write(_textBox.Text);
            }
        }
    }
}
