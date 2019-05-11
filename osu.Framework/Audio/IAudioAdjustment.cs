// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Bindables;

namespace osu.Framework.Audio
{
    public interface IAudioAdjustment
    {
        IBindable<double> Volume { get; }
        IBindable<double> Balance { get; }
        IBindable<double> Frequency { get; }
    }
}
