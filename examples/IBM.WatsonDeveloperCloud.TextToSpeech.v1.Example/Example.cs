﻿/**
* Copyright 2017 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System;
using System.Threading.Tasks;
using IBM.WatsonDeveloperCloud.Util;
using Newtonsoft.Json.Linq;

namespace IBM.WatsonDeveloperCloud.TextToSpeech.v1.Example
{
    public class Example
    {
        static void Main(string[] args)
        {
            string credentials = string.Empty;

            try
            {
                credentials = Utility.SimpleGet(
                    Environment.GetEnvironmentVariable("VCAP_URL"),
                    Environment.GetEnvironmentVariable("VCAP_USERNAME"),
                    Environment.GetEnvironmentVariable("VCAP_PASSWORD")).Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Failed to get credentials: {0}", e.Message));
            }

            Task.WaitAll();

            var vcapServices = JObject.Parse(credentials);
            var _url = vcapServices["text_to_speech"]["url"].Value<string>();
            var _username = vcapServices["text_to_speech"]["username"].Value<string>();
            var _password = vcapServices["text_to_speech"]["password"].Value<string>();

            TextToSpeechServiceExample _textToSpeechExample = new TextToSpeechServiceExample(_url, _username, _password);
            Console.ReadKey();
        }
    }
}
