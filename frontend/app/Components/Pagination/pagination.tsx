'use client'

import { useRouter, useSearchParams } from "next/navigation"
import { FC } from "react";

interface PaginationProps {
    hasNextPage: boolean,
    hasPrevPage: boolean
}

// Pagination controls, Display what page you're on and max amount of pages. Will disable button if conditions are met. Followed Youtube guide, Link: https://www.youtube.com/watch?v=SXmni_7B0r4
const Pagination: FC<PaginationProps> = ({
    hasNextPage, hasPrevPage
}) => {
    const router = useRouter();
    const searchParams = useSearchParams();

    const page = searchParams.get('page') ?? '1';
    const perPage = searchParams.get('per_page') ?? '6';

    return (
        <section className="paginationWrapper">
            <button disabled={!hasPrevPage} onClick={() =>router.push(`/?page=${Number(page) - 1}&per_page=${perPage}`)}>prev page</button>
            {page} / {Math.ceil(60 / Number(perPage))}
            <button disabled={!hasNextPage} onClick={() => router.push(`/?page=${Number(page) + 1}&per_page=${perPage}`)}>next page</button>
        </section>
    )
}

export default Pagination;