using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace C_sharp.DataType
{
    public class FileHandler{
        public string ReadFile(string path){
            Console.WriteLine($"Reading file from {path}");
            string content = File.ReadAllText(path);
            return content;
        }

        public void WriteFile(string path, string content){
            Console.WriteLine($"Writing file to {path}");
            File.WriteAllText(path, content);
        }

        public List<string> GetSubString(string content){
            List<string> subStrings = new List<string>();
            string word = "";
            for(int i =0; i < content.Length; i++){
                if(content[i] == ' '){
                    subStrings.Add(word);
                    word = "";
                }else{
                    word += content[i];
                }
            }
            subStrings.RemoveAll(item => item == "");
            return subStrings;
        }
        public bool CheckTypeValue(string subString){
            if(int.TryParse(subString, out int number)){
                return true;
            }
            return false;
        }

        public void SortElementFile(string path){
            string content = ReadFile(path);
            List<string> subStrings = GetSubString(content);
            List<int> numbers = new List<int>();
            var outputPath = "/home/thuong/SoftMartTraining/C_sharp/DataStorage/output1.txt";
            
            try{
                foreach(string subString in subStrings){
                    bool checkType = CheckTypeValue(subString);
                    if(!checkType){
                        var message = $"Invalid number {subString}";
                        WriteFile(outputPath, message);
                        return;
                    }
                    else{
                        int number = int.Parse(subString);
                        if(number >= 0 && number < 100000){
                           numbers.Add(number);
                        }
                        else {
                           number = -1;
                           numbers.Add(number);
                        }
                    } 
                }
                numbers.Sort();
                string sortedContent = "";
                foreach(int number in numbers){
                    sortedContent += number + " ";
                }
                WriteFile(outputPath, sortedContent);
            }catch(Exception e){
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
            
        }

        // static void Main(string[] args){
        //     FileHandler fileHandler = new FileHandler();
        //     string path = "/home/thuong/SoftMartTraining/C_sharp/DataStorage/testcase1.txt";
        //     string content = fileHandler.ReadFile(path);
        //     fileHandler.SortElementFile(path);
        // }

    }
}