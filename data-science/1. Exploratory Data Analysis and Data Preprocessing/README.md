# Section 1 - EDA and Data Preprocessing

## Section Introducrion:

Data scientists spend the majority of their time on data preparation tasks which should give you a clear idea of how important this process is to data analysis, data science, and machine learning.

Data preparation can be boiled down to three major steps: selection, preprocessing, and transformation.  Exploratory data analysis (EDA) is an integral aspect of any data science project.  EDA allows data scientists to analyse, investigate, and extract the main characteristics of a data set through data visualisation.  Once we have indentified the key characteristics of the data set, we can select those features and ignore any insignificant features.

Data cleansing which is essentially dealing with missing values, outliers, and imbalanced data.  This includes dropping instances/attributes of missing values; imputing the attribute for all missing values; identifying outliers and whether to remove them and normalising or standardising data. 


In this section we will cover EDA and Data Preparation in order to prepare for the future Data Modelling. You need choose **two** datasets from the following dataset list and preprocess data in **both** of the following two datasets.

By now, you should be able to setup a Jupyter instance and be familiar with at least some basics of Python in [this module](https://docs.microsoft.com/en-us/learn/paths/beginner-python/).

## Requirements:
* [Python 3.8+](https://www.python.org/)

Recommended Python package:
* Pandas
* Seaborn
* Matplotlib.pyplot


## Dataset list:
*
*
*


## Getting started:
Install the following libraries as listed in `requirements.txt` via the command:

```bash
pip install -r requirements.txt
```

It is recommended to use a virtual environment. A `submission.ipynb` notebook is provided for your convenience.

Examples of the below processes is shown on respective folders in this directory but note that they may use more simplified datasets so they are at best used as guides. The process applied in the examples may not exactly apply to the current dataset given.

## Part 1 - Exploratory Data Analysis (EDA):
Before doing any processing on the data, it is essential that a data scientist has to know at least the general format of the data and the statistics of said data.

You are expected to show at least the following without hard-coding the values:

Numerically:
- [ ] Average.
- [ ] Standard Deviation.
- [ ] Percentile range either:
    - [ ] 10th and 90th or
    - [ ] 25th and 75th.

Graphically:
- [ ] Correlation Plot.
- [ ] Graphing any Numerical Sections of the dataset.

In addition:
- [ ] Comment on the dataset that is provided to you based on the EDA.

You are also to convert any columns to their appropriate types when required.
