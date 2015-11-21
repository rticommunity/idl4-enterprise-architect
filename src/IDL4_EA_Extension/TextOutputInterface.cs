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

namespace IDL4_EA_Extension
{
    public interface TextOutputInterface
    {
        void OutputText(int depth, String text);
        void OutputText(String text);
        void OutputTextLine(int depth, String text);
        void OutputTextLine(String text);
        void OutputTextLine();

        void Clear();
        int GetCurrentPosition();
        void ClearPositionRange(int beginPosition, int endPosition);

        void SaveToFile(String filePath, String[] preambleLines);
    }
}
