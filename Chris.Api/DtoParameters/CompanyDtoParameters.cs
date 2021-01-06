﻿namespace Chris.Api.DtoParameters
{
    public class CompanyDtoParameters
    {
        private const int MaxPageSize = 20;

        public string CompanyName { get; set; }

        public string SearchTerm { get; set; }

        private int _pageNumber = 1;
        public int PageNumber
        {
            get => _pageNumber;
            set => _pageNumber = value <= 0 ? 1 : value;
        }

        private int _pageSize = 5;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string OrderBy { get; set; } = "CompanyName";
        public string Fields { get; set; }
    }
}
