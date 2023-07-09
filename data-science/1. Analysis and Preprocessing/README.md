# Part 1 - Analysis and Preprocessing

Believe it or not, data scientists spend the majority of their time on data preparation and not on building machine learning models as many people think they do! This should give you an idea of how important data preparation is to data analysis, machine learning, and data science overall. Data preparation can be boiled down to some key steps: data selection, exploratory data analysis (EDA), data preprocessing, and data transformation. Of course, we aren't going to get you to spend nearly all your time in Phase 2 just doing data preparation, but this part is intended to get you practicing some of the most commonly used skills in data science, namely EDA and data preprocessing. 

This part is about exploratory data analysis (EDA) and data preprocessing. EDA is an integral aspect of any data science project. EDA allows data scientists to analyse, investigate, and extract key characteristics and trends within a dataset through data visualisations. Once you know things like the statistics and data formats of the columns within the dataset, the next step (i.e. preprocessing) becomes a lot easier! 

Upon identifying and analysing the main characteristics and trends of a dataset, we can move on to data preprocessing which results in a dataset that's ready to be fed into a machine learning model for training and evaluation. The work you do for this part directly feeds into the second part where you use the datasets you've prepared for model training and evaluation.

## Tasks

To help you analyse and preprocess your datasets, we have split up EDA and data preprocessing into the following tasks to complete. We have also provided a `part1-submission.ipynb` notebook to use as a template for these tasks. You may adapt this notebook as you wish and/or create your own.

  1. [Find all variables and understand them](#1-Find-all-variables-and-understand-them)
  2. [Visualise data](#2-Visualise-data)
  3. [Clean data](#3-Clean-data)
  4. [Identify correlated variables](#4-Identify-correlated-variables)
  5. [Summary](#5-Summary)

### 1. Find all variables and understand them

- Load your chosen datasets from the [datasets folder](https://github.com/NZMSA/2023-Phase-2/tree/main/data-science/0.%20Resources/datasets) into your notebook and show the first ten instances.
- Show (at minimum) the following without hard-coding the values:
    - Numerically
        - Mean
        - Standard Deviation
    - Graphically
        - Plots of any numerical columns in the raw dataset e.g. bar plots, histograms, box and whisker plots etc.
- Convert the data types of any columns (if needed) to the most appropriate data type for doing preprocessing on those columns
    - Note that all values of any feature being fed into a machine learning model should be numerical (not strings, booleans, lists etc.)

### 2. Visualise data

- Visualise the converted data from the task above and identify any trends, patterns, or anomalies
    - Note that there are many different ways to visualise data, so we recommend that you go through the Microsoft Learn modules to see what kinds of visualisations you have learned about and create those (or something similar) for this task.
    - If any columns of the raw data were already numeric, then you may not have modified them further and have already graphicaly shown them in the task above (in which case skip this task for those columns, as we are only interested in how you visualise the non-numerical columns that you converted in the task above)

### 3. Clean data

- For each dataset, take appropriate steps to handle things like:
    - missing values by e.g. dropping instances with missing values or entire attribute containing missing values, imputing the missing values for a particular attribute
    - outliers by e.g. removing them, standardising/normalising them so that all our feature ranges are similar to each other which helps our model learn better
    - imbalanced data by e.g. undersampling/oversampling for a particular label
    - features by e.g. selecting the most important features to feed into our model while ignoring any insignificant features

### 4. Identify correlated variables

- Find correlations between variables within each dataset to figure out how each variable is related to the others.
- Identify and highlight any apparent relationships between variables.

### 5. Summary

- Write a brief summary that highlights:
    - The steps you've taken to perform EDA and preprocessing in order to prepare your datasets for training and evaluation.
    - Any interesting things you found during EDA and preprocessing that you'd like to mention in order to showcase the extent of your understanding of the datasets and the data preparation process.

### Bonus

If you would like to extend yourself (and potentially attain a mark greater than 100% for this part!), then here are some additional tasks you can do on top of the above. 
    - Perform any aspect of EDA or preprocessing in Power BI.
        - This would be most suitable for performing data visualisation.
    - Use the results of your correlation analysis to select the most relevant features or create new ones.
        - This is not something that was covered in detail in the Microsoft Learn modules, but we recommend searching online for "feature selection" and "feature engineering".

## Submission

To complete this part, please include the following items in your repository:

1. A Jupyter notebook (.ipynb) containing your EDA and preprocessing work for your chosen classification dataset
2. A Jupyter notebook (.ipynb) containing your EDA and preprocessing work for your chosen regression dataset
3. A summary (a Markdown cell in each notebook you create, .txt, .pdf, or in another readable format)
    - Think of this as a TL;DR for your notebooks.
    - While there is no word limit, we may penalise summaries that are more than 500 words long (we have a lot of submissions to get through, so the more concise you can be, the better!), or do not provide a sufficient overview of everything you have done. A key skill to master in data science is your ability to communicate technical concepts in a clear way.

## Marking Criteria

1. Task Completion

For each task, we will be making sure that you have met the criteria below. 

- Find all variables and understand them
    - You have read in your chosen datasets appropriately and imported the correct packages
    - You have demonstrated a good understanding of your chosen datasets, by showing, analysing, or correctly calculating (but not limited to) the following:
        - number of instances and features
        - data types of each column
        - values such as the mean and standard deviation
- Visualise data
    - You have used appropriate data visualisation techniques for each dataset (as taught in the Microsoft Learn modules) to explore the data and identify any trends, patterns, or anomalies
- Clean data
    - You have dealt with outliers, missing values, and non-significant features
    - You have converted non-numerical and categorical columns to numerical ones with techniques like one-hot encoding
    - You have provided some reasoning or justification for each step you have taken to clean the data
- Identify correlated variables
    - You have shown the correlation between variables using a correlation matrix, heatmap, or otherwise
- Summary
    - You have summarised what you have found during EDA
    - You have concisely described the preprocessing steps you have taken for each of your chosen datasets

2. Presentation
    - Your notebook/s and the code within them must be well-commented so that someone looking at your notebook/s for the first time can easily understand and follow along with what you did
        - Note that "well-commented" means that you have provided easily understandable explanations for what the results of your code mean or what you have inferred from them
        - We may penalise notebooks that only contain code and nothing else.
    - Your comments clearly explain the EDA and preprocessing steps you have taken and justify why you took those steps

## Tips

- This part relies heavily on the Microsoft Learn modules from Weeks 1, 2, and 6 of Phase 1! In particular, we recommend that you go through the following units, modules, code snippets, and external resources for each task to support your work:
    - Find all variables and understand them
        - ```python
            df = pd.read_csv("example.csv")
            df.head()
            # Get more information about the dataset columns such as their data types (column metadata and units are not provided as part of this task to allow for an unbiased exploration of data without knowing a lot of information about the features beforehand)
            df.info()
            ```
    - Visualise data
        - Units 4 to 7 of [Explore and analyze data with Python](https://learn.microsoft.com/en-us/training/modules/explore-analyze-data-with-python/?ns-enrollment-type=Collection&ns-enrollment-id=n2kyanp2128q50)
        - [All Week 6 modules on Power BI](https://github.com/NZMSA/2023-Phase-1#data-science-5)
        - ```python
            import matplotlib.pyplot as plt
            ```
    - Clean data
        - [Handling categorical features](https://wandb.ai/wandb_fc/kaggle_tutorials/reports/Handling-Categorical-Features-With-Examples--VmlldzoyMTY4NDgz)
        - Units 2 and 3 of [Explore and analyze data with Python](https://learn.microsoft.com/en-us/training/modules/explore-analyze-data-with-python/?ns-enrollment-type=Collection&ns-enrollment-id=n2kyanp2128q50)
        - Unit 5 of [Data collection and manipulation](https://learn.microsoft.com/en-us/training/modules/collect-manipulate-data-python-nasa/?ns-enrollment-type=Collection&ns-enrollment-id=n2kyanp2128q50)
    - Identify correlated variables
        - Units 6 and 7 of [Explore and analyze data with Python](https://learn.microsoft.com/en-us/training/modules/explore-analyze-data-with-python/?ns-enrollment-type=Collection&ns-enrollment-id=n2kyanp2128q50)
        - [How to use a heatmap to plot a correlation matrix](https://towardsdatascience.com/seaborn-heatmap-for-visualising-data-correlations-66cbef09c1fe)

- More often than not, data scientists need to go back to their EDA and preprocessing steps after realising they need to analyse or prepare their data better or in a different way. So don't be afraid to revisit this part after you think you've completed it, and write about any changes you made to your EDA and preprocessing steps in your summary!