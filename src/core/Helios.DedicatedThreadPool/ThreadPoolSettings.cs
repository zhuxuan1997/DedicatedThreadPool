﻿using System;

namespace Helios.DedicatedThreadPool
{
    /// <summary>
    /// The type of threads to use - either foreground or background threads.
    /// </summary>
    public enum ThreadType
    {
        Foreground,
        Background
    }

    /// <summary>
    /// Provides settings for a dedicated thread pool
    /// </summary>
    public class HeliosThreadPoolSettings
    {
        public HeliosThreadPoolSettings(int numThreads, ThreadType threadType)
        {
            ThreadType = threadType;
            NumThreads = numThreads;
            if(numThreads <= 0) 
                throw new ArgumentOutOfRangeException("numThreads", string.Format("numThreads must be at least 1. Was {0}", numThreads));
        }

        /// <summary>
        /// The total number of threads to run in this thread pool.
        /// </summary>
        public int NumThreads { get; private set; }

        /// <summary>
        /// The type of threads to run in this thread pool.
        /// </summary>
        public ThreadType ThreadType { get; private set; }
    }
}
