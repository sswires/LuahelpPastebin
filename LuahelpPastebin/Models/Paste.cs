using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuahelpPastebin.Models
{
    /// <summary>
    /// Represents a single selectable language
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Unique identifier for this language
        /// </summary>
        [Key, MaxLength(25)]
        public string Id { get; set; }

        /// <summary>
        /// Long descriptive name of language
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// Represents a single paste in the database
    /// </summary>
    public class Paste
    {
        /// <summary>
        /// Unique ID for this page
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Title of paste, shown above the code
        /// </summary>
        [StringLength(150)]
        public string Title { get; set; }

        /// <summary>
        /// Code entered by the user
        /// </summary>
        [Required, DataType(DataType.MultilineText)]
        public string Code { get; set; }

        /// <summary>
        /// GUID of user who posted this, null if guest
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// If user isn't present, use this for their name
        /// </summary>
        public string GuestName { get; set; }

        /// <summary>
        /// When this paste was submitted
        /// </summary>
        public DateTime SubmitTime { get; set; }

        /// <summary>
        /// When will this code expire
        /// </summary>
        public DateTime? ExpireTime { get; set; }

        /// <summary>
        /// ID of the language the code should be highlighted in
        /// </summary>
        public string LanguageId { get; set; }

        /// <summary>
        /// The language this code should be highlighted in
        /// </summary>
        [ForeignKey("LanguageId")]
        public Language Language { get; set; }

        /// <summary>
        /// The ID of the paste this is an alteration of
        /// </summary>
        public int? AlteredId { get; set; }

        /// <summary>
        /// This paste this is an alteration of
        /// </summary>
        [ForeignKey("AlteredId")]
        public Paste Altered { get; set; }

        /// <summary>
        /// A collection of direct alterations to this code
        /// </summary>
        public ICollection<Paste> Alterations { get; set; }
    }
}