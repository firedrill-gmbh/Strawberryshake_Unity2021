using UnityEngine;
using StrawberryShake;
using Microsoft.Extensions.DependencyInjection;
using Demo;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TMPro;

namespace VRTX
{
    public class GraphQLTest : MonoBehaviour
    {
        public TextMeshProUGUI log;

        private StrawberryShakeImplementation strawberryShake = null;
        private IConferenceClient client;

        public void InitGrapQL()
        {
            strawberryShake = new StrawberryShakeImplementation();
            var result = strawberryShake.Init();
            AddToLog(result);
        }

        public void ResetGraphQL()
        {
            strawberryShake.Reset();
            ClearLog();
        }

        public async void RunGrapQLQuery()
        {
           var result = await strawberryShake.RunQuery();
           AddToLog(result);
        }

        public void AddToLog(string value)
        {
            Debug.Log(value);
        }

        public void ClearLog()
        {
            log.text = "";
        }


    }
}