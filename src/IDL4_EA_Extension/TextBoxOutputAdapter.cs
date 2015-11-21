/*********************************************************************************************
Copyright 2015 Real-Time Innovations, Inc.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
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

        public int GetCurrentPosition()
        {
            return _textBox.SelectionStart;
        }

        public void ClearPositionRange(int beginPosition, int endPosition)
        {
            _textBox.Select(beginPosition, endPosition);
            _textBox.Cut();
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
