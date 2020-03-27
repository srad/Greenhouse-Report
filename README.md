# Greenhouse Report

[![Build Status](http://jenkins.sedrad.com/buildStatus/icon?job=Greenhouse-Report)](http://jenkins.sedrad.com/job/Greenhouse-Report/)

## Setup

Clone the repository:

```bash
git clone https://github.com/srad/Greenhouse-Report.git
cd Greenhouse-Report
```

Install the needed packages:

```bash
make install
```

The authors are not checked in for privacy reasons, but are stored in `authors.tex` locally.

All `authors.tex.default` must be renamed to `authors.tex` and define the author names (or leave the default).

To get quickly running just rename the default files:

```bash
make setup
```

## Build the document

Compile the document just run:

```bash
make
```

On windows you should be able to just use your favourite Latex environment, just compile `main.tex` in your IDE on Windows.

Both will generate the final document `main.pdf`.

## Include Graphics and Code

### Images / Graphics

Since at the top of every member directory `\graphicspath{{members/<name>/figures/}}` is set,
you can just put your graphics in each folder's `figures` folder and include them via `\includegraphics{filename.ext}`.

### Code

Including code requires to define the whole path, i.e.:

```latex
\lstinputlisting[language=Python, linerange={12-14}, frame=single, caption = Given a folder \textit{directory\_im} containing obj files a specific number of plants are randomly selected ]{members/cm/import_plants.py}\vspace{5pt}
```
