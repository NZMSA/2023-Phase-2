# Section 1 - EDA and Data Preprocessing

## Section Introducrion:

Data scientists spend the majority of their time on data preparation tasks which should give you a clear idea of how important this process is to data analysis, data science, and machine learning.

Data preparation can be boiled down to three major steps: selection, preprocessing, and transformation.  Exploratory data analysis (EDA) is an integral aspect of any data science project.  EDA allows data scientists to analyse, investigate, and extract the main characteristics of a data set through data visualisation.  Once we have indentified the key characteristics of the data set, we can select those features and ignore any insignificant features.

Data cleansing which is essentially dealing with missing values, outliers, and imbalanced data.  This includes dropping instances/attributes of missing values; imputing the attribute for all missing values; identifying outliers and whether to remove them and normalising or standardising data. 


In this section we will cover EDA and Data Preparation in order to prepare for the following Data Modelling sections. You need choose **two** datasets from the following dataset list and preprocess data in **both** of the following two datasets.

The structure of this section is as follows:

  - [1. Finding all Variables and Understanding Them.](#step-0-splitting-the-dataset)
  - [Step 1: Choosing a model](#step-1-choosing-a-model)
  - [Step 2: Training and testing](#step-2-training-and-testing)
  - [Step 3: Evaluation](#step-3-model-evaluation)
  - [Step 4: Optimizing](#step-4-optimizing)

Finally, you should submit the follwing files:
* Two .ipynb files (one for each dataset) with clear comments.
* A brief summary describes how you performed EDA and preprocessing, as well as your understanding of the data.

By now, you should be able to setup a Jupyter instance and be familiar with at least some basics of Python in [this module](https://docs.microsoft.com/en-us/learn/paths/beginner-python/).

## Requirements:
* [Python 3.8+](https://www.python.org/)

Recommended Python package:
* Pandas
* Seaborn
* Matplotlib.pyplot


## Dataset list:

#### Regression Problem 
* [Data science job salary](https://www.kaggle.com/datasets/arnabchaki/data-science-salaries-2023)
* [Exam score prediction](https://www.kaggle.com/datasets/desalegngeb/students-exam-scores)

#### Classification Problem
* [US census income](https://archive.ics.uci.edu/ml/datasets/Census+Income)
* [Credit risk prediction](https://www.kaggle.com/datasets/ppb00x/credit-risk-customers)
* [Customer segmentation](https://www.kaggle.com/datasets/abisheksudarshan/customer-segmentation)

## Getting started:
Install the following libraries as listed in `requirements.txt` via the command:

```bash
pip install -r requirements.txt
```

It is recommended to use a virtual environment. A `submission.ipynb` notebook is provided for your convenience.

## Task list:

You need to complete the following tasks:

### 1. Finding all Variables and Understanding Them. 
Before doing any processing on the data, it is essential that a data scientist has to know at least the general format of the data and the statistics of said data.

You are expected to show at least the following without hard-coding the values:

Numerically:
* Average.
* Standard Deviation.

Graphically:
* Graphing any Numerical Sections of the dataset.

You also need to convert any columns to their appropriate types when required.


### 2. Cleaning the Dataset.
You need to explore data with NumPy and Pandas (As we learned from week module in phase 1).
Remove the missing values, outliers and irrelevant features from the dataset. 

### 3. Visualize data 
Visualize data with Matplotlib in python (required). 
Attempting to implement visualization using Power BI (optional). 


### 3. Identify Correlated Variables.
Finding a correlation between the variables. It will help you figure out how one variable is related others.

Recommend:
* Correlation Plot. 


### 4. Visualizing and Analyzing Results.



In addition:

