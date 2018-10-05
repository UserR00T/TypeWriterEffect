# TypeWriterEffect

> Adds a TypeWriter effect to Windows Forms Application.

![](https://i.imgur.com/8AqlUU3.gif)

Version: [MP4](https://puu.sh/BGe5p/a6d56a0711.mp4) | [GIF](https://i.imgur.com/8AqlUU3.gif)

## Installation

1. Goto ``'Releases'``.
2. Download the latest version.
3. Reference the ``.dll`` into your Windows Forms Application project.

## How to use
1. Create a new ``Typewriter`` by typing
```CSharp
new Typewriter(Label, List<Label>, delayInMiliSeconds, repeatCursorTimes = 5, waitAtEndDelay = 0, start = true)
``` 
2. You can use the ``.Stop()``, ``.Start()``, and ``.Toggle()`` methods on the ``Typewriter`` instance.

## Example

```CSharp
// ...
using TypewriterEffect;
// ...
public static Typewriter typeWriter;
private void Main_Load(object sender, EventArgs e)
{
    var list = new List<Typewriter.Label>
    {
        new Typewriter.Label("TypeWriterEffect", Typewriter.Label.LabelMode.OverwriteText),
        new Typewriter.Label("Adds a TypeWriter effect to Windows Forms Application.", Typewriter.Label.LabelMode.OverwriteText),
        new Typewriter.Label("Created by UserR00T.", Typewriter.Label.LabelMode.OverwriteText)
    };
    typeWriter = new Typewriter(mainLabel, list, 70, 2, 300);
}
private void ToggleBtn_Click(object sender, EventArgs e)
{
    typeWriter.Toggle();
}
private void ForceEnableBtn_Click(object sender, EventArgs e)
{
    typeWriter.Start();
}
private void ForceDisableBtn_Click(object sender, EventArgs e)
{
    typeWriter.Stop();
}
private void DisposeBtn_Click(object sender, EventArgs e)
{
    typeWriter.Dispose();
}
```

## Methods

Method | Function
--- | ---
``.Start()`` | Starts the typewriter.
``.Stop()`` | Stops the typewriter.
``.Toggle()`` | Toggles the typewriter.

## Constructor Arguments

```CSharp
 public Typewriter(System.Windows.Forms.Label textLabel, List<Label> messages, int delayInMiliSeconds, int repeatCursorTimes = 5, int waitAtEndDelay = 0, bool start = true)
```

Argument | Type | Default | Function
--- | --- | --- | ---
``Label`` | ``Panel`` | --- | The label this instance should work on.
``messages`` | ``List<Label>`` | --- | List of messages it'll go through.
``delayInMiliSeconds`` | ``int`` | --- | The delay between ticks in milliseconds.
``repeatCursorTimes`` | ``int`` | ``5`` | How many times should it repeat the ending cursor?
``waitAtEndDelay`` | ``int`` | ``0`` | Should it wait at the end for a specified amount of milliseconds?
``start`` | ``bool`` | ``true`` | Start typewriter once constructed?
