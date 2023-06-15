# Part 1 - Analysis and Preprocessing

Believe it or not, data scientists spend the majority of their time on data preparation and not on building machine learning models as many people think they do! This should give you an idea of how important data preparation is to data analysis, machine learning, and data science overall. Data preparation can be boiled down to some key steps: data selection, exploratory data analysis (EDA), data preprocessing, and data transformation. Of course, we aren't going to get you to spend nearly all your time in Phase 2 just doing data preparation, but this part is intended to get you practicing some of the most commonly used skills in data science, namely EDA and data preprocessing.

EDA is an integral aspect of any data science project. EDA allows data scientists to analyse, investigate, and extract key characteristics and trends within a dataset through data visualisations. Once you know things like the statistics and data formats of the columns within the dataset, the next step (i.e. preprocessing) becomes a lot easier!

Upon identifying and analysing the main characteristics and trends of a dataset, we can move onto data preprocessing which will result in a dataset that's ready to be fed into a machine learning model for training and evaluation.

## Getting Started

To help you analyse and preprocess your datasets, we have split up EDA and data preprocessing into four tasks to complete. We have also provided a `submission.ipynb` notebook to use as a template for these tasks. You may adapt this notebook as you wish.

  1. [Find all variables and understand them](#1-Find-all-variables-and-understand-them)
  2. [Clean data](#2-Clean-data)
  3. [Visualise data](#3-Visualise-data)
  4. [Identify correlated variables](#4-Identify-correlated-variables)

### 1. Find all variables and understand them

- Load your chosen datasets from the [datasets folder]() into your notebook and show the first ten instances.
- Show (at minimum) the following without hard-coding the values:
    - Numerically
        - Mean
        - Standard Deviation
    - Graphically
        - Plots of any numerical columns e.g. bar plots, histograms, box and whisker plots etc.
- Convert the data types of any columns (if needed) to the most appropriate data type for doing preprocessing on those columns
    - Note that all values of any feature being fed into a machine learning model should be numerical (not strings, booleans, lists etc.)

### 2. Clean data

- For each dataset, take appropriate steps to handle things like:
    - missing values by e.g. dropping instances with missing values or entire attribute containing missing values, imputing the missing values for a particular attribute
    - outliers by e.g. removing them, standardising/normalising them so that all our feature ranges are similar to each other which helps our model learn better
    - imbalanced data by e.g. undersampling/oversampling for a particular label
    - features by e.g. selecting the most important features to feed into our model while ignoring any insignificant features

### 3. Visualise data

- Visualise the data and identify any trends, patterns, or anomalies
    - Note that there are many different ways to visualise data, so we recommend that you go through the Microsoft Learn modules to see what kinds of visualisations you have learned about and create those (or something similar) for this task.

### 4. Identify correlated variables

- Find correlations between variables within each dataset to figure out how each variable is related to the others.
- Identify and highlight any apparent relationships between variables.

## Tips

- This part relies heavily on the Microsoft Learn modules from Weeks 1, 2, and 6 of Phase 1! In particular, we recommend that you go through the following units, modules, code snippets, and external resources for each task to support your work:
    - Finding all variables and understanding them
        - ```python
            df = pd.read_csv("example.csv"); df.head()
            ```
    - Data cleaning
        - Units 2 and 3 of [Explore and analyze data with Python](https://learn.microsoft.com/en-us/training/modules/explore-analyze-data-with-python/?ns-enrollment-type=Collection&ns-enrollment-id=n2kyanp2128q50)
        - Unit 5 of [Data collection and manipulation](https://learn.microsoft.com/en-us/training/modules/collect-manipulate-data-python-nasa/?ns-enrollment-type=Collection&ns-enrollment-id=n2kyanp2128q50)
    - Data visualisation
        - Units 4 to 7 of [Explore and analyze data with Python](https://learn.microsoft.com/en-us/training/modules/explore-analyze-data-with-python/?ns-enrollment-type=Collection&ns-enrollment-id=n2kyanp2128q50)
        - [All Week 6 modules on Power BI](https://github.com/NZMSA/2023-Phase-1#data-science-5)
        - ```python
            import matplotlib.pyplot as plt
            ```
    - Identifying correlated variables
        - Units 6 and 7 of [Explore and analyze data with Python](https://learn.microsoft.com/en-us/training/modules/explore-analyze-data-with-python/?ns-enrollment-type=Collection&ns-enrollment-id=n2kyanp2128q50)
        - [How to use a heatmap to plot a correlation matrix](https://towardsdatascience.com/seaborn-heatmap-for-visualising-data-correlations-66cbef09c1fe)
- The work you do in this part directly feeds into the next part where you use the datasets you've prepared for model training and evaluation. More often that not, data scientists need to go back to their EDA and preprocessing steps after realising they need to analyse or prepare their data better or in a different way. So don't be afraid to revisit this part after you think you've completed it, and write about any changes you made to your EDA and preprocessing steps in your summary after working on the second part.

## Submission

To complete this part, please include the following items in your repository:

1. A Jupyter notebook (.ipynb) containing your EDA and preprocessing work for your chosen classification dataset
2. A Jupyter notebook A Jupyter notebook (.ipynb) containing your EDA and preprocessing work for your chosen regression dataset
3. A brief summary (a Markdown cell in each notebook, .txt, .pdf, or in another readable format) that highlights:
    - the steps you've taken to perform EDA and preprocessing in order to prepare your datasets for training and evaluation
    - any interesting things you found during EDA and preprocessing that you'd like to mention in order to showcase the extent of your understanding of the datasets and the data preparation process

## Marking Schedule

1. Task Completion

For each task, we will be making sure that you have done some key things, as listed below. Please note that we are marking students across a wide range of skill levels, so if you are
    
- Data selection and understanding
    - You have read in your chosen datasets appropriately and imported the corect packages
    - You have demonstrated a good understanding of your chosen datasets, by showing and/or analysing (but not limited to) these things:
        - number of instances and features
        - data types of each column
        - expected values
- Data visualisation
    - Using Matplotlib (or other commonly used Python library), you have used appropriate data visualisation techniques for each dataset (as taught in the Microsoft Learn modules) to explore the data and identify any trends, patterns, or anomalies
- Data cleaning
    - You have dealt with outlier, missing values, and non-significant features
    - You have converted non-numerical columns to numerical ones
    - You have provided some reasoning or justification for each step you have taken to clean the data
- Identifying correlated variables
    - You have shown the correlation between variables using a correlation matrix, heatmap, or otherwise
- Summary
    - At the end of your notebook, you have summarised what you have found during EDA, and concisely described the preprocessing steps you have taken for each of your chosen datasets.
        - Think of this as a TL;DR for your notebook.
        - While there is no word limit, we may penalise summaries that are more than 500 words long (we have a lot of submissions to get through, so the more concise you can be, the better!), or do not provide a sufficient overview of everything you have done.
            - A key skill to master in data science is your ability to communicate technical concepts in a clear way.

2. Presentation
    - Your notebooks and the code within them must be well-commented
        - Note that "well-commented" means that you have provided easily understandable explanations for what the results of your code mean or what you have inferred from them
        - We may penalise notebooks that only contain code and nothing else.
    - Your comments clearly explain the EDA and preprocessing steps you have taken and justify why you took those steps

3. Bonus

If you would like to extend yourself (and potentially attain a mark greater than 100%!), then here are some additional things you can do on top of the above. 
    - Perform any aspect of EDA or preprocessing in Power BI.
        - This would be most suitable for performing data visualisation.
    - Use the results of your correlation analysis to select the most relevant features or create new ones.
        - This is not something that was covered in detail in the Microsoft Learn modules, but we recommend searching online for "feature selection" and "feature engineering".