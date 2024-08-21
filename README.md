# Picture Tag Renamer with Viewer

## What it does
Is a small lightweight app I created so I could add tags to the name of the picture.
Includes:
- Custom controls
- MIME validation
- Folder navigation

The only reason I'm publishing this is because I found a way around the memory leaking bitmap type in .Net.
Loading new pictures to a pictureBox by the way of repeated Bitmap instances is a serious memory eater.
Garbage collector can't catch a break when dealing with all those created instances. Sooner or later it will collapse.
Worst of all, setting your bitmap to a new variable doesn't help at all because it behaves as a reference, killing your picture viewer.

- Repeated bitmaps eat into your memory
- Bitmpap behaves as a reference so assigning to new var

## The way around

Being just an amateur programmer, I offer you my two cents.
Convert your Bitmap to Memory Stream and dispose of it once you're done tinkering with it. This will free the memory used by bitmap.
But you now have your picture in an easily disposable memory stream. Extract into your pictureBox and dispose. And your RAM is safe.

- Convert bitmap to memory stream
- Dispose of bitmap
- Extract picture from memory steam
- 💰 Profit ✨

> I'm fairly sure better and optimized
> methods exist to do this, so take it
> as it comes.

This text you see here is *actually- written in Markdown! To get a feel
for Markdown's syntax, type some text into the left window and
watch the results in the right.

**Disclaimer: some assets in this project may be copyrighted**
