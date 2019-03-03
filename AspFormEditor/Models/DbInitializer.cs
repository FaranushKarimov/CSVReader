// <copyright file="DbInitializer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AspFormEditor.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// DbInitializer class.
    /// </summary>
    public class DbInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        /// <summary>
        /// Seed method.
        /// </summary>
        /// <param name="context">Seed add</param>
        protected override void Seed(DataContext context)
        {
            base.Seed(context);

            Form first = new Form() { FormTitle = "Первая форма", Description = "Тестовая форма 1" };
            first.Fields.Add(new Field() { FieldTitle = "Первое поле", Type = Type.Paragraph, Question = "Первый вопрос", Required = true });
            first.Fields.Add(new Field() { FieldTitle = "Второе поле", Type = Type.ListMany, Question = "Второй вопрос 1\nВторой вопрос 2", Required = false });

            Form second = new Form() { FormTitle = "Вторая форма", Description = "Тестовая форма 2" };
            second.Fields.Add(new Field() { FieldTitle = "Первое поле", Type = Type.Paragraph, Question = "Первый вопрос", Required = true });
            second.Fields.Add(new Field() { FieldTitle = "Второе поле", Type = Type.ListOne, Question = "Второй вопрос 1\nВторой вопрос 2", Required = false });
            second.Fields.Add(new Field() { FieldTitle = "Третье поле", Type = Type.Text, Question = "Третий вопрос", Required = false });
            second.Fields.Add(new Field() { FieldTitle = "Четвертое поле", Type = Type.Dropdown, Question = "Четвертый вопрос 1\nЧетвертый вопрос 2\nЧетвертый вопрос", Required = false });

            Form third = new Form() { FormTitle = "Третья форма", Description = "Тестовая форма 3" };
            third.Fields.Add(new Field() { FieldTitle = "Первое поле", Type = Type.Paragraph, Question = "Первый вопрос", Required = true });

            context.Forms.AddRange(new List<Form>() { first, second, third });
        }
    }
}