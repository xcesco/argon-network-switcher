using System;
using System.Collections.Generic;
using System.Text;

/*
 * Copyright 2012 Francesco Benincasa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
namespace Argon.Common
{
    /// <summary>
    /// Usefull class to get time enlapsed between two instants.
    /// </summary>
    public class PerformanceUtility
    {
        /// <summary>
        /// tempo iniziale
        /// </summary>
        private DateTime startTime;

        /// <summary>
        /// Inizia il conteggio del tempo
        /// </summary>
        public void StartTimer()
        {
            startTime = DateTime.Now;
        }

        /// <summary>
        /// Calcola quanto tempo è trascorso dall'inizio della misurazione del
        /// tempo. Il parametro <code>resetTimer</code> se è impostato a <code>true</code>
        /// effettua il reset del timer. In caso tale parametro sia posto a <code>false</code>
        /// l'inizio del timer rimarrà invariato.
        /// </summary>
        /// <param name="resetTimer">se true effettua il reset del timer.</param>
        /// <returns>tempo trascorso in millisecondi</returns>
        public long GetEnlapsedTime(bool resetTimer)
        {            
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;

            if (resetTimer)
            {
                startTime = DateTime.Now;
            }

            return (long)duration.TotalMilliseconds;         
        }

        /// <summary>
        /// Calcola quanto tempo è trascorso dall'inizio della misurazione del
        /// tempo. Effettua il reset del timer, ovvero la volta successiva che viene 
        /// eseguito tale metodo il tempo viene considerato dall'invocazione del 
        /// metodo.
        /// </summary>
        /// <returns>tempo trascorso in millisecondi</returns>
        public long GetEnlapsedTime()
        {
            return GetEnlapsedTime(true);
        }
    }
}
